using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    
    public partial class Photos
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoTitle { get; set; }
        public int? PhotoViews { get; set; }
        public string PhotoAddedData { get; set; }
        public int? NewsId { get; set; }

        [NotMapped]
        [Required]
        public IEnumerable<IFormFile> FormFile { get; set; }
        public News News { get; set; }
    }
}
