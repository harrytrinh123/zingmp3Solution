using System;
using System.Collections.Generic;
using System.Text;

namespace zingmp3Solution.Data.Entities
{
    public class Singer
    {
        public int Id { get; set; }
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string ImageAvatar { get; set; }
        public string FullName { get; set; }
        public string StageName { get; set; }
        public string Introduction { get; set; }

}
}
