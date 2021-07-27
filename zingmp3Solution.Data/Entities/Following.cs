using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Following
    {
        
        public int FollowerId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
