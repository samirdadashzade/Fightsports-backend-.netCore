using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FightSports.Models
{
    public partial class MelumatComments
    {
        public int MelumatCommentId { get; set; }
        [Required]
        public string MelumatCommentAuthorName { get; set; }
        [Required]
        public string MelumatCommentTxt { get; set; }
        public string MelumatCommentDate { get; set; }
        public int? MelumatId { get; set; }

        public Melumat Melumat { get; set; }
    }
}
