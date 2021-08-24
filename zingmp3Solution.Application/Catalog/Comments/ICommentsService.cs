using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Comments;

namespace zingmp3Solution.Application.Catalog.Comments
{
    public interface ICommentsService
    {
        Task<List<CommentsDto>> GetComment();
        Task<CommentsDto> GetCommentsByID(int id);
        Task AddComment(CommentsDto comments);
        Task DeleteComment(CommentsDto comments);
        Task<CommentsDto> EditComment();
    }
}
