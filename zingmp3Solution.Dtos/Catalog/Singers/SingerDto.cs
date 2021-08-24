using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Dtos.Catalog.Singers
{
    public class SingerDto
    {
        public int id { get; set; }
        public DateTime Dob { get; set; }
        public bool Sex { get; set; }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public string StageName { get; set; }
        public string Introduction { get; set; }
    }
}
