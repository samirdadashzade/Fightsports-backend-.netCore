﻿using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class NewsType
    {
        public NewsType()
        {
            News = new HashSet<News>();
        }

        public int NewsTypeId { get; set; }
        public string NewsTypeName { get; set; }

        public ICollection<News> News { get; set; }
    }
}
