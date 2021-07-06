using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreatedDate { get; set; }
        public string Dob { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string ImageAvatar { get; set; }
    }
}
