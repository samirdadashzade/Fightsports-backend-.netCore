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
            viewModel.Admins = _context.Admin.ToList();
            viewModel.Comments = _context.Comments.ToList();
            viewModel.LiveTvs = _context.LiveTv.ToList();
            viewModel.Magazines = _context.Magazine.ToList();
            viewModel.News = _context.News.ToList();
            viewModel.NewsTypes = _context.NewsType.ToList();
            viewModel.Photos = _context.Photos.ToList();
            viewModel.SportCategories = _context.SportCategories.ToList();
            viewModel.Melumats = _context.Melumat.ToList();

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
            ViewBag.masterClass = _context.News.Where(x => x.NewsType.NewsTypeName == "melumat").ToList();
            ViewBag.fotos = _context.News.Where(x => x.NewsType.NewsTypeName == "foto").ToList();
            ViewBag.videos = _context.News.Where(x => x.NewsFirstVideoPath != null).ToList();

            _context.SaveChanges();

            return View(Vm());
        }

        public IActionResult SportsPage(int? id)
        {
            ViewBag.SportCategories = _context.SportCategories.ToList();
            ViewBag.Melumats = _context.Melumat.Where(x => x.SportCategoryId == id).ToList();
            ViewBag.Magazine = _context.Magazine.Where(x=>x.SportCategoryId == id).ToList();

            ViewBag.infoLent = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "infolent").ToList();
            ViewBag.videos = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "video" && x.NewsFirstVideoPath != null).ToList();
            ViewBag.photos = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "foto").ToList();
            ViewBag.masterClass = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "masterklass").ToList();
            ViewBag.expert = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "ekspert").ToList();
            ViewBag.club = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "klub").ToList();
            ViewBag.federation = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "federasiya").ToList();
            ViewBag.report = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "reportaj").ToList();
            ViewBag.exclusive = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "ekskluziv").ToList();
            ViewBag.person = _context.News.Where(x => x.SportCategoryId == id && x.NewsType.NewsTypeName == "persona").ToList();

            return View(_context.News.Where(x => x.SportCategoryId == id).ToList());
        }

        public IActionResult News(int? id)
        {
            var newsWithPhotos = (from news in _context.News
                                  join photos in _context.Photos
                                  on news.NewsId equals photos.NewsId
                                  select new NewsWithPhotos
                                  {
                                      NewsBigTitle = news.NewsBigTitle,
                                      NewsId = news.NewsId,
                                      NewsName = news.NewsName,
                                      NewsTitle = news.NewsTitle,
                                      NewsTxt = news.NewsTxt,
                                      NewsFirstVideoPath = news.NewsFirstVideoPath,
                                      NewsViews = news.NewsViews,
                                      PhotoPath = photos.PhotoPath
                                  }).ToList();

            ViewBag.Comments = _context.Comments.Where(x => x.NewsId == id).ToList();
            ViewBag.newsWithPhotos = newsWithPhotos.Where(x => x.NewsId == id).ToList();
            ViewBag.SportCategories = _context.SportCategories.ToList();
            ViewBag.News = _context.News.ToList();

            var count = 0;

            while (count == 0)
            {
                count++;
                var newsById = _context.News.SingleOrDefault(x => x.NewsId == id);
                newsById.NewsViews += count;
            }

            _context.SaveChanges();

            return View(_context.News.Where(x => x.NewsId == id).ToList());
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

            ViewBag.SportCategories = _context.SportCategories.ToList();
            return View(_context.News.Where(x => x.NewsId == id).ToList());
        }

        public IActionResult Videos()
        {
            var newsWithPhotos = (from news in _context.News
                                  join photos in _context.Photos
                                  on news.NewsId equals photos.NewsId
                                  select new NewsWithPhotos
                                  {
                                      NewsBigTitle = news.NewsBigTitle,
                                      NewsId = news.NewsId,
                                      NewsName = news.NewsName,
                                      NewsTitle = news.NewsTitle,
                                      NewsTxt = news.NewsTxt,
                                      NewsFirstVideoPath = news.NewsFirstVideoPath,
                                      NewsViews = news.NewsViews,
                                      PhotoPath = photos.PhotoPath
                                  }).ToList();

            ViewBag.SportCategories = _context.SportCategories.ToList();
            ViewBag.News = _context.News.ToList();

            return View(_context.News.ToList());
        }

        public IActionResult Photos()
        {
            var newsWithPhotos = (from news in _context.News
                                  join photos in _context.Photos
                                  on news.NewsId equals photos.NewsId
                                  select new NewsWithPhotos
                                  {
                                      NewsBigTitle = news.NewsBigTitle,
                                      NewsId = news.NewsId,
                                      NewsName = news.NewsName,
                                      NewsTitle = news.NewsTitle,
                                      NewsTxt = news.NewsTxt,
                                      NewsFirstVideoPath = news.NewsFirstVideoPath,
                                      NewsViews = news.NewsViews,
                                      PhotoPath = photos.PhotoPath
                                  }).ToList();

            ViewBag.SportCategories = _context.SportCategories.ToList();
            ViewBag.News = _context.News.ToList();

            return View(_context.News.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
