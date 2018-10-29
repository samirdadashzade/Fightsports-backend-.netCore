using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FightSports.Models
{
    public partial class Magazine
    {
        public int MagazineId { get; set; }
        public string ProductName { get; set; }
        public string MagazineAdress { get; set; }
        public string MagazineLongitude { get; set; }
        public string MagazineLatitude { get; set; }
        public string ProductTxt { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public int SportCategoryId { get; set; }
        public string MagazineFirstPhotoPath { get; set; }
        public string MagazineSecondPhotoPath { get; set; }
        public string MagazineThirdPhotoPath { get; set; }
        public string MagazineFourthPhotoPath { get; set; }
        public string MagazineFifthPhotoPath { get; set; }

        [NotMapped]
        public IFormFile FormFile { get; set; }
        [NotMapped]
        public IFormFile SecondFormFile { get; set; }
        [NotMapped]
        public IFormFile ThirdFormFile { get; set; }
        [NotMapped]
        public IFormFile FourthFormFile { get; set; }
        [NotMapped]
        public IFormFile FifthFormFile { get; set; }

        public SportCategories SportCategory { get; set; }
    }
}
