using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreatedDate { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string Avatar { get; set; }

        // Relationship
        public List<LovePost> LovePosts { get; set; }
        public List<Following> Followings { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
