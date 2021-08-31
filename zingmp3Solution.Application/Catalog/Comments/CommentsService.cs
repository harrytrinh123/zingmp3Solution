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

        public async Task<CommentsDto> AddComment(Guid UserId, int PostId, CommentCreateDto comments)
        {
            var commetCurrent = new Comment()
            {
                Text = comments.Text,
                PostId = PostId,
                UserId = UserId
            };
            _context.Comments.Add(commetCurrent);
            await _context.SaveChangesAsync();

            return new CommentsDto()
            {
                Id = commetCurrent.Id,
                Text = commetCurrent.Text,
                PostId = commetCurrent.PostId,
                UserId = commetCurrent.UserId
            };
        }

        public async Task DeleteComment(CommentsDto comments)
        {
            var commentCurrent = await _context.Comments.FindAsync(comments.Id);
            if (commentCurrent != null)
            {
                _context.Remove(commentCurrent);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<CommentsDto> EditComment(int id, CommentUpdateDto comment)
        {
            var commentCurrent = await _context.Comments.FindAsync(id);
            if (commentCurrent == null) throw new Exception($"Not found {id} in comment");
            commentCurrent.Text = comment.Text;
            commentCurrent.PostId = comment.PostId;
            commentCurrent.UserId = comment.UserId;
            _context.Comments.Update(commentCurrent);
            await _context.SaveChangesAsync();
            return new CommentsDto() { 
                Id = id,
                Text = commentCurrent.Text,
                PostId = commentCurrent.PostId,
                UserId = commentCurrent.UserId
            };
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
