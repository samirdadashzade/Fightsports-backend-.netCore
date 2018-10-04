using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightSports.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace FightSports.Controllers
{
    public class HomeController : Controller
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;        

        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();

            viewModel.Photos = _context.Photos;
            viewModel.Banners = _context.Banners;

            //List<ViewModel> viewModelList = new List<ViewModel>();

            //foreach (var item in _context.Photos)
            //{
            //    ViewModel viewModel = new ViewModel();
            //    viewModel.PhotoName = item.PhotoName;
            //    viewModelList.Add(viewModel);
            //}

            //foreach (var item in _context.Banners)
            //{
            //    ViewModel viewModel = new ViewModel();
            //    viewModel.BannerPath = item.BannerPath;
            //    viewModelList.Add(viewModel);
            //}

            return View();
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
