using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}
