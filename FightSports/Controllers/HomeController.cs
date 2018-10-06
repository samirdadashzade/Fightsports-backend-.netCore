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

        public List<ViewModel> Vm()
        {
            var viewModelList = new List<ViewModel>();

            foreach (var item in _context.Admin.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.AdminId = item.AdminId;
                viewModel.AdminName = item.AdminName;
                viewModel.AdminPassword = item.AdminPassword;

                viewModelList.Add(viewModel);
            }

            foreach (var item in _context.Banners.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.BannerId = item.BannerId;
                viewModel.BannerPath = item.BannerPath;
                viewModel.CustumerName = item.CustumerName;

                viewModelList.Add(viewModel);
            }

            foreach (var item in _context.Comments.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.CommentId = item.CommentId;
                viewModel.CommentTxt = item.CommentTxt;
                viewModel.CommentDate = item.CommentDate;
                viewModel.AuthorName = item.AuthorName;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.LiveTv.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.LiveTvId = item.LiveTvId;
                viewModel.LiveTitle = item.LiveTitle;
                viewModel.LivePath = item.LivePath;

                viewModelList.Add(viewModel);
            }

            foreach (var item in _context.Magazine.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.MagazineId = item.MagazineId;
                viewModel.ProductName = item.ProductName;
                viewModel.MagazineAdress = item.MagazineAdress;
                viewModel.MagazineLatitude = item.MagazineLatitude;
                viewModel.MagazineLongitude = item.MagazineLongitude;
                viewModel.ProductTxt = item.ProductTxt;
                viewModel.ProductPrice = item.ProductPrice;
                viewModel.ProductTitle = item.ProductTitle;
                viewModel.SportCategoryIdFK = item.SportCategoryId;

                viewModelList.Add(viewModel);
            }

            foreach (var item in _context.MagazinePhotos.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.MagazinePhotoId = item.MagazinePhotoId;
                viewModel.MagazinePhotoPath = item.MagazinePhotoPath;
                viewModel.MagazinePhotoName = item.MagazinePhotoName;
                viewModel.MagazineIdFK = item.MagazineId;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.News.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.NewsId = item.NewsId;
                viewModel.NewsName = item.NewsName;
                viewModel.NewsTitle = item.NewsTitle;
                viewModel.NewsBigTitle = item.NewsBigTitle;
                viewModel.NewsTxt = item.NewsTxt;
                viewModel.NewsViews = item.NewsViews;
                viewModel.NewsAddedDate = item.NewsAddedDate;
                viewModel.OptionalLatitude = item.OptionalLatitude;
                viewModel.OptionalLongitude = item.OptionalLongitude;
                viewModel.NewsTypeIdFk = item.NewsTypeId;
                viewModel.SportCategoryIdFKNews = item.SportCategoryId;
                viewModel.OptionalAdress = item.OptionalAdress;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.NewsType.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.NewsTypeId = item.NewsTypeId;
                viewModel.NewsTypeName = item.NewsTypeName;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.Photos.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.PhotoId = item.PhotoId;
                viewModel.PhotoName = item.PhotoName;
                viewModel.PhotoPath = item.PhotoPath;
                viewModel.PhotoTitle = item.PhotoTitle;
                viewModel.PhotoViews = item.PhotoViews;
                viewModel.PhotoAddedDate = item.PhotoAddedData;
                viewModel.NewsIdFk = item.NewsId;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.SportCategories.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.SportCategoryId = item.SportCategoryId;
                viewModel.SportCategoryName = item.SportCategoryName;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.Videos.ToList())
            {
                var viewModel = new ViewModel();
                viewModel.VideoId = item.VideoId;
                viewModel.VideoName = item.VideoName;
                viewModel.VideoTitle = item.VideoTitle;
                viewModel.VideoPath = item.VideoPath;
                viewModel.VideoAddedDate = item.VideoAddedDate;
                viewModel.NewsIdFk = item.NewsId;

                viewModelList.Add(viewModel);
            }
            foreach (var item in _context.Banners.ToList())
            {
                ViewModel viewModel = new ViewModel();
                viewModel.BannerPath = item.BannerPath;
                viewModelList.Add(viewModel);
            }

            return viewModelList;
        }

        public IActionResult Index()
        {
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
