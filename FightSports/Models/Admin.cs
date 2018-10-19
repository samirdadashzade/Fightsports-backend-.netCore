using System;
using System.Collections.Generic;

namespace FightSports.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public int? AdminPassword { get; set; }
        public string AdminEmail { get; set; }
    }
}
