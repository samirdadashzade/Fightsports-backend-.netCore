using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Videos
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public string VideoTitle { get; set; }
        public int? VideoViews { get; set; }
        public string VideoPath { get; set; }
        public string VideoAddedDate { get; set; }
        public int? NewsId { get; set; }

        public News News { get; set; }
    }
}
