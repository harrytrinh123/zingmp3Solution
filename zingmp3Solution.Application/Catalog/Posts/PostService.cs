using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Posts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace zingmp3Solution.Application.Catalog.Posts
{
    public class PostService : IPostService
    {
        private readonly ZingMp3DbContext _context;
        public PostService(ZingMp3DbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(PostCreateDto request)
        {
            var postCreate = new Post()
            {
                FilePostUrl = "file path",
                Text = request.Text,
                UserId = request.UserId
            };
            _context.Posts.Add(postCreate);
            await _context.SaveChangesAsync();
            return postCreate.Id;
        }

        public async Task<int> Delete(int postId)
        {
            var post = await _context.Songs.FindAsync(postId);
            if (post == null) throw new Exception($"Can not find post with id: {postId}");
            _context.Remove(post);
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
            post.FilePostUrl = request.FilePostUrl;
            post.Text = request.Text;
            post.UserId = request.UserId;
            return await _context.SaveChangesAsync();
        }
    }
}
