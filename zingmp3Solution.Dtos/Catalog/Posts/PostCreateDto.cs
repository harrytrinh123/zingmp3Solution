using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Posts
{
    public class PostCreateDto
    {
        public string Text { get; set; }
        public IFormFile File { get; set; }
        public Guid UserId { get; set; }
    }
}
