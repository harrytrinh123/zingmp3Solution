using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Posts
{
    public class PostUpdateDto
    {
        public string Text { get; set; }
        public string FilePostUrl { get; set; }
        public IFormFile File { get; set; }
        public Guid UserId { get; set; }
    }
}
