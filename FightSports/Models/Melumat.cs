using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FightSports.Models
{
    public partial class Melumat
    {
        public Melumat()
        {
            MelumatComments = new HashSet<MelumatComments>();
        }

        public int MelumatId { get; set; }
        public string MelumatTxt { get; set; }
        public string MelumatPhotoPath { get; set; }
        public string MelumatAdress { get; set; }
        public int? SportCategoryId { get; set; }

        [NotMapped]
        public IFormFile FormFile { get; set; }
        public SportCategories SportCategory { get; set; }
        public ICollection<MelumatComments> MelumatComments { get; set; }
    }
}
