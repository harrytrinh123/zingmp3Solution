using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Songs
{
    public class SongCreateDto
    {
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public string SongUrl { get; set; }
        public string SongImage { get; set; }
        public int LoveCount { get; set; }
        public int ListenCount { get; set; }
        public string Musician { get; set; }
        public string Duration { get; set; }
        public string SingersString { get; set; }
        public int CategoryId { get; set; }
    }
}
