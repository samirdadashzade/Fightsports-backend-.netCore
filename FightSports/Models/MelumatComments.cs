using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class MelumatComments
    {
        public int MelumatCommentId { get; set; }
        public string MelumatCommentAuthorName { get; set; }
        public string MelumatCommentTxt { get; set; }
        public string MelumatCommentDate { get; set; }
        public int? MelumatId { get; set; }

        public Melumat Melumat { get; set; }
    }
}
