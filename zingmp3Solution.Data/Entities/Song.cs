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
        public string SongUrl { get; set; }
        public string SongImage { get; set; }
        public int LoveCount { get; set; }
        public int ListenCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Musician  { get; set; }
        public string Duration { get; set; }
        public string SingersString { get; set; }

        //Relationship

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Song_Singer> Song_Singers { get; set; }
        public List<Song_Playlist> Song_Playlists { get; set; }



    }
}
