using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Posts;

namespace zingmp3Solution.Application.Catalog.Posts
{
    public class PostService : IPostService
    {
        public Task<int> Create(PostCreateDto request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostDto>> GetPaged(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<PostDto> GetPostById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int postId, PostUpdateDto request)
        {
            throw new NotImplementedException();
        }
    }
}
