using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class MagazinePhotos
    {
        public int MagazinePhotoId { get; set; }
        public string MagazinePhotoPath { get; set; }
        public string MagazinePhotoName { get; set; }
        public int MagazineId { get; set; }

        public Magazine Magazine { get; set; }
    }
}
