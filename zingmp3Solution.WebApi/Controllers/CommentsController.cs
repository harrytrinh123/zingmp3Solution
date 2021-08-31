using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Comments;
using zingmp3Solution.Dtos.Catalog.Comments;

namespace zingmp3Solution.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private ICommentsService _comment;

        public CommentsController(ICommentsService comment)
        {
            _comment = comment;
        }

        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            return Ok(await _comment.GetComment());
        }

        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public async Task<IActionResult> GetCommentsByID(int id)
        {
            var comment = await _comment.GetCommentsByID(id);
            if (comment != null)
            {
                return Ok(comment);
            }

            return NotFound($"Id {id} not list Comments");
        }

        [HttpPost()]
        public async Task<IActionResult> AddComment(Guid UserId, int PostId, [FromForm] CommentCreateDto comments)
        {
            var comment = await _comment.AddComment(UserId, PostId, comments);
            return Ok(comment);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteComment(CommentsDto comments)
        {
            await _comment.DeleteComment(comments);
            return Ok(comments);
        }

        [HttpPatch]
        [Route("/api/[controller]/{id}")]
        public async Task<IActionResult> UpdateComment(int id, CommentUpdateDto comment)
        {
            var commentCurrent = await _comment.EditComment(id, comment);
            return Ok(commentCurrent);
        }
    }
}
