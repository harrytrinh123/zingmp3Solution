using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPublic{ get; set; }
        public bool IsRandom{ get; set; }

    }
}
