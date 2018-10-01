using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class Photos
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoTitle { get; set; }
        public int? PhotoViews { get; set; }
        public DateTime? PhotoAddedData { get; set; }
        public int NewsId { get; set; }

        public News News { get; set; }
    }
}
