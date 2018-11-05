using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ViewModel
    {
        public IEnumerable<Banners> Banners { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
        public IEnumerable<LiveTv> LiveTvs { get; set; }
        public IEnumerable<Magazine> Magazines { get; set; }
        public IEnumerable<News> News { get; set; }
        public IEnumerable<NewsType> NewsTypes { get; set; }
        public IEnumerable<Photos> Photos { get; set; }
        public IEnumerable<SportCategories> SportCategories { get; set; }
        public IEnumerable<Videos> Videos { get; set; }
        public IEnumerable<Melumat> Melumats { get; set; }
    }
}