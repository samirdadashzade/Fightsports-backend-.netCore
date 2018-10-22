﻿using System;
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
            viewModel.Melumats = _context.Melumat.ToList();

            return viewModel;
        }

        public IActionResult Index()
        {
            return View(Vm());
        }

        public IActionResult SportsPage(int? id)
        {
            ViewBag.SportCategories = _context.SportCategories.ToList();
            ViewBag.Melumats = _context.Melumat.Where(x => x.SportCategoryId == id).ToList();
            ViewBag.Magazine = _context.Magazine.Where(x => x.SportCategoryId == id).ToList();


            ViewBag.MagazinePhotos = _context.MagazinePhotos.ToList();

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
            ViewBag.Test = _context.News.ToList();

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
            ViewBag.SportCategories = _context.SportCategories.ToList();
            return View(_context.News.Where(x => x.NewsId == id).ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
