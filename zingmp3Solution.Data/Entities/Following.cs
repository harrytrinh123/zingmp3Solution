using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Following
    {
        
        public Guid FollowerId { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
