using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FightSports.Models
{
    public partial class Banners
    {
        public int BannerId { get; set; }
        public string CustumerName { get; set; }
        public string BannerPath { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
    }
}
