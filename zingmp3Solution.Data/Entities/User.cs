using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string CreatedDate { get; set; }
        public string Dob { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        // Relationship
        public List<LovePost> LovePosts { get; set; }
        public List<Following> Followings { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
