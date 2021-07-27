using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Song_Playlist
    {

        public int SongId { get; set; }
        public Song Song { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

    }
}
