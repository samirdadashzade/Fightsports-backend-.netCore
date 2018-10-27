using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FightSports.Models
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string CommentTxt { get; set; }
        public string CommentDate { get; set; }
        public string AbstractCommentType { get; set; }
        public int? NewsId { get; set; }

        public News News { get; set; }
    }
}
