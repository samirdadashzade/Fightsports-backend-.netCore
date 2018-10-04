using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FightSports.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FightSports.Controllers
{
    public class PhotosController : Controller
    {
        private readonly CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;
        IHostingEnvironment _appEnvironment;

        public PhotosController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            var cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext = _context.Photos.Include(p => p.News);
            return View(await cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photos
                .Include(p => p.News)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // GET: Photos/Create
        public IActionResult Create()
        {
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsTitle");
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Photos photos)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_appEnvironment.WebRootPath, Path.GetFileName(photos.formFile.FileName));
                photos.PhotoPath = "/" + Path.GetFileName(photos.formFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await photos.formFile.CopyToAsync(stream);
                }

                _context.Add(photos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsBigTitle", photos.NewsId);
            return View(photos);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photos.FindAsync(id);
            if (photos == null)
            {
                return NotFound();
            }
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsTitle", photos.NewsId);
            return View(photos);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoId,PhotoName,PhotoPath,PhotoTitle,PhotoViews,PhotoAddedData,NewsId")] Photos photos)
        {
            if (id != photos.PhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotosExists(photos.PhotoId))
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
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsTitle", photos.NewsId);
            return View(photos);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photos
                .Include(p => p.News)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photos = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotosExists(int id)
        {
            return _context.Photos.Any(e => e.PhotoId == id);
        }
    }
}
