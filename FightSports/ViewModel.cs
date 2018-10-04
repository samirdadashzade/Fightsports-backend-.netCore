using FightSports.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightSports
{
    public class ViewModel
    {
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Banners> Banners { get; set; }
    }
}