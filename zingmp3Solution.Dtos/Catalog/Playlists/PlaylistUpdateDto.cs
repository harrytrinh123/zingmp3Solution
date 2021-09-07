using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Playlists
{
    public class PlaylistUpdateDto
    {
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public bool IsRandom { get; set; }

        public string Image { get; set; }

    }
}
