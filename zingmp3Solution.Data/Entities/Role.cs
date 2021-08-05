using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}
