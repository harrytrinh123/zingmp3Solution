using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Comments;

namespace zingmp3Solution.Application.Catalog.Comments
{
    public class CommentsService : ICommentsService
    {
        private ZingMp3DbContext _context;
        public CommentsService(ZingMp3DbContext context)
        {
            _context = context;
        }

        public async Task AddComment(CommentsDto comments)
        {
            var commetCurrent = new Comment()
            {
                Id = comments.Id,
                Text = comments.Text,
                PostId = comments.Id,
                UserId = comments.UserId
            };
            _context.Comments.Add(commetCurrent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteComment(CommentsDto comments)
        {
            var commentCurrent = await _context.Comments.FindAsync(comments.Id);
            if(commentCurrent != null)
            {
                _context.Remove(commentCurrent);
                await _context.SaveChangesAsync();
            }
        }

        public Task<CommentsDto> EditComment()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CommentsDto>> GetComment()
        {
            var commentsCurrent = _context.Comments.Select(s => new CommentsDto()
            {
                Id = s.Id,
                Text = s.Text,
                PostId = s.PostId,
                UserId = s.UserId
            });
            return await commentsCurrent.ToListAsync();
        }

        public async Task<CommentsDto> GetCommentsByID(int id)
        {
            var commentsCurrents = await _context.Comments.FindAsync(id);
            return new CommentsDto()
            {
                Id = commentsCurrents.Id,
                Text = commentsCurrents.Text,
                PostId = commentsCurrents.PostId,
                UserId = commentsCurrents.UserId
            };
        }
    }
}
