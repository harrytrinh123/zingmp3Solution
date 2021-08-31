using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Dtos.Catalog.Comments
{
    public class CommentsDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
        public Guid UserId { get; set; }
    }
}
