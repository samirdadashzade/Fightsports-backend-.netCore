using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using WebApplication1.Data;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewModel Vm()
        {
            var viewModel = new ViewModel();
            viewModel.Banners = _context.Banners.ToList();
            viewModel.Comments = _context.Comments.ToList();
            viewModel.LiveTvs = _context.LiveTv.ToList();
            viewModel.Magazines = _context.Magazine.ToList();
            viewModel.News = _context.News.ToList();
            viewModel.NewsTypes = _context.NewsType.ToList();
            viewModel.Photos = _context.Photos;
            viewModel.SportCategories = _context.SportCategories.ToList();
            viewModel.Melumats = _context.Melumat.ToList();

            ViewBag.SportCategories = _context.SportCategories.ToList();

            return viewModel;
        }

        public IActionResult Search(string id)
        {
            var result = _context.News.Where(x => x.NewsTitle.Contains(id) ||
                                                    x.NewsName.Contains(id) || 
                                                    x.NewsTxt.Contains(id) || 
                                                    x.NewsBigTitle.Contains(id));

            return Json(result);
        }
      
        public IActionResult Index()
        {
            return View(Vm());
        }

        public IActionResult SportsPage(int? id)
        {
            Vm();

            var melumats = _context.Melumat.Where(x => x.SportCategoryId == id).ToList();
            var news = _context.News.Include(c => c.NewsType).Where(x => x.SportCategory.SportCategoryId == id).ToList();
            var magazines = _context.Magazine.Where(x => x.SportCategoryId == id).ToList();

            return View(Tuple.Create(news, melumats, magazines));
        }

        public IActionResult News(int? id)
        {
            var count = 0;

            while (count == 0)
            {
                count++;
                var newsById = _context.News.SingleOrDefault(x => x.NewsId == id);
                newsById.NewsViews += count;
            }

            _context.SaveChanges();

            Vm();

            var news = _context.News.Where(x => x.NewsId == id).ToList();
            var photos = _context.Photos.Where(x => x.News.NewsId == id).ToList();
            var newsAll = _context.News.ToList();

            return View(Tuple.Create(photos,news,newsAll));
        }

        public IActionResult ClubAndFederation(int? id)
        {
            var count = 0;

            while (count == 0)
            {
                count++;
                var newsById = _context.News.SingleOrDefault(x => x.NewsId == id);
                newsById.NewsViews += count;
            }

            _context.SaveChanges();

            Vm();
            return View(_context.News.Where(x => x.NewsId == id).ToList());
        }

        public IActionResult Videos()
        {
            return View(Vm());
        }

        public IActionResult Photos()
        {
            return View(Vm());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
