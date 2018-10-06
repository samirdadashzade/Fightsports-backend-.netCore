using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string AuthorName { get; set; }
        public string CommentTxt { get; set; }
        public string CommentDate { get; set; }
        public int NewsId { get; set; }

        public News News { get; set; }
    }
}
