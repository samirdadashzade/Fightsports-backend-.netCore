using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class LiveTv
    {
        public int LiveTvId { get; set; }
        public string LivePath { get; set; }
        public string LiveTitle { get; set; }
        public string LivePhotoPath { get; set; }

        [NotMapped]
        [Required]
        public IFormFile FormFile { get; set; }
    }
}
