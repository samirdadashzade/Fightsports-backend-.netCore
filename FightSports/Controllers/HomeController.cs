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
            var viewModel = new ViewModel();
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
            return View(Vm());
        }

        public IActionResult SportsPage(int? id)
        {
            //var NewsWithPhotosList = (from news in _context.News
            //                          select new NewsWithPhotos
            //                          {
            //                              NewsId = news.NewsId,
            //                              NewsTitle = news.NewsTitle,
            //                              NewsName = news.NewsName,
            //                              NewsTxt = news.NewsTxt,
            //                              SportCategoryId = news.SportCategoryId,
            //                              NewsAddedDate = news.NewsAddedDate,
            //                              NewsBigTitle = news.NewsBigTitle,
            //                              NewsFirstPhotoPath = news.NewsFirstPhotoPath,
            //                              NewsViews = news.NewsViews

            //                          }).ToList();
            ViewBag.SportCategories = _context.SportCategories.ToList();

            return View(_context.News.Where(x => x.SportCategoryId == id).ToList());
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
