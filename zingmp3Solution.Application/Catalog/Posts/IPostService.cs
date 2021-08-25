using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Posts;

namespace zingmp3Solution.Application.Catalog.Posts
{
    public interface IPostService
    {
        Task<List<PostDto>> GetPaged(int pageIndex, int pageSize);
        // CRUD
        Task<PostDto> GetPostById(int postId);
        Task<int> Create(PostCreateDto request);
        Task<int> Update(int postId,PostUpdateDto request);
        Task<int> Delete(int postId);
    }
}
