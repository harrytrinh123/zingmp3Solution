using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Songs
{
    public class SongAndCountLove : SongDto
    {
        public List<int> Hours { get; set; }
        public List<int> ViewInHours { get; set; }
    }
}
