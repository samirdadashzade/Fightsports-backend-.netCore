using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class Magazine
    {
        public Magazine()
        {
            MagazinePhotos = new HashSet<MagazinePhotos>();
        }

        public int MagazineId { get; set; }
        public string ProductName { get; set; }
        public string MagazineAdress { get; set; }
        public int? MagazineLongitude { get; set; }
        public int? MagazineLatitude { get; set; }
        public string ProductTxt { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public int SportCategoryId { get; set; }

        public SportCategories SportCategory { get; set; }
        public ICollection<MagazinePhotos> MagazinePhotos { get; set; }
    }
}
