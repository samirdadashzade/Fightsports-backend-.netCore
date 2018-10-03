using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightSports.Models;

namespace FightSports.Controllers
{
    public class HomeController : Controller
    {
        private readonly CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public IActionResult Index()
        {          
            ViewModel viewModel = new ViewModel();
            foreach (var item in _context.Photos)
            {
                viewModel.PhotoName = item.PhotoName;
            }

            foreach (var item in _context.Banners)
            {
                viewModel.CustumerName = item.CustumerName;
            }

            return View(viewModel);
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
