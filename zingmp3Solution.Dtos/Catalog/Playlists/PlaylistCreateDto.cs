using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Playlists
{
    public class PlaylistCreateDto
    {
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public bool IsRandom { get; set; }
    }
}
