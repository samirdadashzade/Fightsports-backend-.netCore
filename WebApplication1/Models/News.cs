using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class News
    {
        public News()
        {
            Comments = new HashSet<Comments>();
            Photos = new HashSet<Photos>();
            Videos = new HashSet<Videos>();
        }

        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBigTitle { get; set; }
        public string NewsTxt { get; set; }
        public int NewsViews { get; set; }
        public string NewsAddedDate { get; set; }
        public string OptionalLongitude { get; set; }
        public string OptionalLatitude { get; set; }
        public int NewsTypeId { get; set; }
        public int SportCategoryId { get; set; }
        public string OptionalAdress { get; set; }
        public string NewsFirstPhotoPath { get; set; }
        public string NewsFirstVideoPath { get; set; }
        [NotMapped]
        [Required]
        public IFormFile FormFile { get; set; }
        public NewsType NewsType { get; set; }
        public SportCategories SportCategory { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Photos> Photos { get; set; }
        public ICollection<Videos> Videos { get; set; }
    }
}
