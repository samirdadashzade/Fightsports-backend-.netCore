using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class BannersController : Controller
    {
        public ApplicationDbContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public BannersController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Banners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Banners.ToListAsync());
        }

        // GET: Banners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banners = await _context.Banners
                .FirstOrDefaultAsync(m => m.BannerId == id);
            if (banners == null)
            {
                return NotFound();
            }

            return View(banners);
        }

        // GET: Banners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Banners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Banners banners)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(banners.FormFile.FileName));
                banners.BannerPath = "/" + Path.GetFileName(banners.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await banners.FormFile.CopyToAsync(stream);
                }

                _context.Add(banners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banners);
        }

        // GET: Banners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banners = await _context.Banners.FindAsync(id);
            if (banners == null)
            {
                return NotFound();
            }
            return View(banners);
        }

        // POST: Banners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Banners banners)
        {
            if (id != banners.BannerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(banners.FormFile.FileName));
                banners.BannerPath = "/" + Path.GetFileName(banners.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await banners.FormFile.CopyToAsync(stream);
                }

                try
                {
                    _context.Update(banners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannersExists(banners.BannerId))
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
            return View(banners);
        }

        // GET: Banners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banners = await _context.Banners
                .FirstOrDefaultAsync(m => m.BannerId == id);
            if (banners == null)
            {
                return NotFound();
            }

            return View(banners);
        }

        // POST: Banners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var banners = await _context.Banners.FindAsync(id);
            _context.Banners.Remove(banners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BannersExists(int id)
        {
            return _context.Banners.Any(e => e.BannerId == id);
        }
    }
}
