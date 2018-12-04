using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Data;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        public ApplicationDbContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public NewsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: News
        public async Task<IActionResult> Index()
        {
            var ApplicationDbContext = _context.News.Include(n => n.NewsType).Include(n => n.SportCategory);
            return View(await ApplicationDbContext.ToListAsync());
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.NewsType)
                .Include(n => n.SportCategory)
                .FirstOrDefaultAsync(m => m.NewsId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: News/Create
        public IActionResult Create()
        {
            ViewData["NewsTypeId"] = new SelectList(_context.NewsType, "NewsTypeId", "NewsTypeName");
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName");
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news)
        {
            if (ModelState.IsValid)
            {
                var date = DateTime.Now.AddHours(4);
                var newsDate = news.NewsAddedDate = date.ToString();

                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(news.FormFile.FileName));
                news.NewsFirstPhotoPath = "/" + Path.GetFileName(news.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await news.FormFile.CopyToAsync(stream);
                }

                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NewsTypeId"] = new SelectList(_context.NewsType, "NewsTypeId", "NewsTypeName", news.NewsTypeId);
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", news.SportCategoryId);
            return View(news);
        }

        // GET: News/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            ViewData["NewsTypeId"] = new SelectList(_context.NewsType, "NewsTypeId", "NewsTypeName", news.NewsTypeId);
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", news.SportCategoryId);
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, News news)
        {
            if (id != news.NewsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var date = DateTime.UtcNow.AddHours(4);
                var newsDate = news.NewsAddedDate = date.ToString();

                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(news.FormFile.FileName));
                news.NewsFirstPhotoPath = "/" + Path.GetFileName(news.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await news.FormFile.CopyToAsync(stream);
                }

                try
                {
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.NewsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["NewsTypeId"] = new SelectList(_context.NewsType, "NewsTypeId", "NewsTypeName", news.NewsTypeId);
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", news.SportCategoryId);
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.NewsType)
                .Include(n => n.SportCategory)
                .FirstOrDefaultAsync(m => m.NewsId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.NewsId == id);
        }
    }
}
