using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Posts;

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
                FilePostUrl = request.FilePostUrl,
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

        public Task<List<PostDto>> GetPaged(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<PostDto> GetPostById(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
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
