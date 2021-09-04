using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Posts;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using zingmp3Solution.Application.Common;

namespace zingmp3Solution.Application.Catalog.Posts
{
    public class PostService : IPostService
    {
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        private readonly ZingMp3DbContext _context;
        private readonly IStorageService _storageService;
        public PostService(ZingMp3DbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        public async Task<int> Create(PostCreateDto request)
        {

            var filePath = "empty";
            if (request.File != null)
            {
                filePath = await this.SaveFile(request.File);
            }
            var postCreate = new Post()
            {
                FilePostUrl = filePath,
                Text = request.Text,
                UserId = request.UserId
            };
            _context.Posts.Add(postCreate);
            await _context.SaveChangesAsync();

            return postCreate.Id;
        }

        public async Task<int> Delete(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post == null) throw new Exception($"Can not find post with id: {postId}");
            _context.Remove(post);
            await _storageService.DeleteFileAsync(post.FilePostUrl);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<PostDto>> GetPaged(int pageIndex, int pageSize)
        {
            var query = from p in _context.Posts
                        select p;
            var posts = await query.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new PostDto()
                {
                    Id = x.Id,
                    FilePostUrl = x.FilePostUrl,
                    Text = x.Text,
                    UserId = x.UserId

                }).ToListAsync();
            return posts;
        }

        public async Task<PostDto> GetPostById(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post == null) return null;
            return new PostDto()
            {
                Id = post.Id,
                FilePostUrl = post.FilePostUrl,
                Text = post.Text,
                UserId = post.UserId
            };
        }

        public async Task<int> Update(int postId, PostUpdateDto request)
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post == null) throw new Exception($"Can not find song with id: {postId}");
            post.Text = request.Text;

            if (request.File != null)
            {
                var filePath = await this.SaveFile(request.File);
                post.FilePostUrl = filePath;
            }

            return await _context.SaveChangesAsync();
        }


        // Save File
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }
    }
}
