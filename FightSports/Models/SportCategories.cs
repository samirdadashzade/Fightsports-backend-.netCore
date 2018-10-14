using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class SportCategories
    {
        public SportCategories()
        {
            Magazine = new HashSet<Magazine>();
            Melumat = new HashSet<Melumat>();
            News = new HashSet<News>();
        }

        public int SportCategoryId { get; set; }
        public string SportCategoryName { get; set; }

        public ICollection<Magazine> Magazine { get; set; }
        public ICollection<Melumat> Melumat { get; set; }
        public ICollection<News> News { get; set; }
    }
}
