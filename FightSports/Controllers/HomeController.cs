using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightSports.Models;
using Microsoft.EntityFrameworkCore;

namespace FightSports.Controllers
{
    public class HomeController : Controller
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public HomeController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context)
        {
            _context = context;
        }

        public ViewModel Vm()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.Banners = _context.Banners.ToList();
            viewModel.Admins = _context.Admin.ToList();
            viewModel.Comments = _context.Comments.ToList();
            viewModel.LiveTvs = _context.LiveTv.ToList();
            viewModel.Magazines = _context.Magazine.ToList();
            viewModel.MagazinePhotos = _context.MagazinePhotos.ToList();
            viewModel.News = _context.News.ToList();
            viewModel.NewsTypes = _context.NewsType.ToList();
            viewModel.Photos = _context.Photos.ToList();
            viewModel.SportCategories = _context.SportCategories.ToList();

            return viewModel;
        }

        public IActionResult Index()
        {
            var NewsWithPhotosList = (from news in _context.News
                                      join photos in _context.Photos
                                      on news.NewsId equals photos.NewsId
                                      select new NewsWithPhotos
                                      {
                                          NewsTitle = news.NewsTitle,
                                          NewsName = news.NewsName,
                                          NewsTxt = news.NewsTxt,
                                          PhotoPath = photos.PhotoPath
                                      });

            ViewBag.forNews = NewsWithPhotosList.ToList();

            return View(Vm());
        }

        public IActionResult SportsPage()
        {
            return View(Vm());
        }

        public IActionResult News()
        {
            return View(Vm());
        }
        
        public IActionResult ClubAndFederation()
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
