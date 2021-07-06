using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Song
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public string SongFile { get; set; }
        public string SongImage { get; set; }
        public int LoveCount { get; set; }
        public int ListenCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Musician  { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Singer Singer { get; set; }

    }
}
