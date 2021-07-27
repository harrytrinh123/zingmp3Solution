using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Song_Singer
    {

        public int SongId { get; set; }
        public Song Song { get; set; }

        public int SingerId { get; set; }
        public Singer Singer { get; set; }
    }
}
