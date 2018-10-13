using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightSports
{
    public class NewsWithPhotos
    {
        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBigTitle { get; set; }
        public string NewsTxt { get; set; }
        public int NewsViews { get; set; }
        public string NewsAddedDate { get; set; }
        public int? OptionalLongitude { get; set; }
        public int? OptionalLatitude { get; set; }
        public int NewsTypeId { get; set; }
        public int SportCategoryId { get; set; }
        public string OptionalAdress { get; set; }
        public string NewsFirstPhotoPath { get; set; }
    }
}