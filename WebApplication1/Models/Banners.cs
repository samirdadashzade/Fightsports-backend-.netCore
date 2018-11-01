using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class Banners
    {
        public int BannerId { get; set; }
        public string CustumerName { get; set; }
        public string BannerPath { get; set; }
        [NotMapped]
        [Required]
        public IFormFile FormFile { get; set; }
    }
}
