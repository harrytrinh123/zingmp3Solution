using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Comments
{
    public class CommentUpdateDto
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public Guid UserId { get; set; }
    }
}
