using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FilePostUrl { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Comment> Comments { get; set; }
        public List<LovePost> LovePosts { get; set; }

    }
}
