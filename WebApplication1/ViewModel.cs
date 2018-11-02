﻿using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ViewModel
    {
        public List<Banners> Banners { get; set; }
        public List<Comments> Comments { get; set; }
        public List<LiveTv> LiveTvs { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<News> News { get; set; }
        public List<NewsType> NewsTypes { get; set; }
        public List<Photos> Photos { get; set; }
        public List<SportCategories> SportCategories { get; set; }
        public List<Videos> Videos { get; set; }
        public List<Melumat> Melumats { get; set; }
    }
}