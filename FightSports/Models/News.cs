using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class News
    {
        public News()
        {
            Comments = new HashSet<Comments>();
            Photos = new HashSet<Photos>();
            Videos = new HashSet<Videos>();
        }

        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBigTitle { get; set; }
        public string NewsUpperTxt { get; set; }
        public string NewsDownTxt { get; set; }
        public int? NewsViews { get; set; }
        public DateTime? NewsAddedDate { get; set; }
        public int? Longitude { get; set; }
        public int? Latitude { get; set; }
        public int NewsTypeId { get; set; }
        public int SportCategoryId { get; set; }

        public NewsType NewsType { get; set; }
        public SportCategories SportCategory { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Photos> Photos { get; set; }
        public ICollection<Videos> Videos { get; set; }
    }
}
