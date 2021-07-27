using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Singer
    {
        public int Id { get; set; }
        public DateTime Dob { get; set; }
        public bool Sex { get; set; }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public string StageName { get; set; }
        public string Introduction { get; set; }

        public int SongId { get; set; }
        public Song Song { get; set; }

        public List<Song_Singer> Song_Singers { get; set; }
    }
}
