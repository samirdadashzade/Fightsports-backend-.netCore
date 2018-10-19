using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FightSports.Models
{
    public partial class MagazinePhotos
    {
        public int MagazinePhotoId { get; set; }
        public string MagazinePhotoPath { get; set; }
        public string MagazinePhotoName { get; set; }
        public int MagazineId { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
        public Magazine Magazine { get; set; }
    }
}
