using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FightSports.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FightSports.Controllers
{
    public class MagazinesController : Controller
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public MagazinesController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Magazines
        public async Task<IActionResult> Index()
        {
            var cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext = _context.Magazine.Include(m => m.SportCategory);
            return View(await cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext.ToListAsync());
        }

        // GET: Magazines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazine = await _context.Magazine
                .Include(m => m.SportCategory)
                .FirstOrDefaultAsync(m => m.MagazineId == id);
            if (magazine == null)
            {
                return NotFound();
            }

            return View(magazine);
        }

        // GET: Magazines/Create
        public IActionResult Create()
        {
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName");
            return View();
        }

        // POST: Magazines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Magazine magazine)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(magazine.FormFile.FileName));
                magazine.MagazineFirstPhotoPath = "/" + Path.GetFileName(magazine.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await magazine.FormFile.CopyToAsync(stream);
                }

                _context.Add(magazine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", magazine.SportCategoryId);
            return View(magazine);
        }

        // GET: Magazines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazine = await _context.Magazine.FindAsync(id);
            if (magazine == null)
            {
                return NotFound();
            }
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", magazine.SportCategoryId);
            return View(magazine);
        }

        // POST: Magazines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MagazineId,ProductName,MagazineAdress,MagazineLongitude,MagazineLatitude,ProductTxt,ProductPrice,ProductTitle,SportCategoryId,MagazineFirstPhotoPath")] Magazine magazine)
        {
            if (id != magazine.MagazineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(magazine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MagazineExists(magazine.MagazineId))
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
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", magazine.SportCategoryId);
            return View(magazine);
        }

        // GET: Magazines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazine = await _context.Magazine
                .Include(m => m.SportCategory)
                .FirstOrDefaultAsync(m => m.MagazineId == id);
            if (magazine == null)
            {
                return NotFound();
            }

            return View(magazine);
        }

        // POST: Magazines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var magazine = await _context.Magazine.FindAsync(id);
            _context.Magazine.Remove(magazine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MagazineExists(int id)
        {
            return _context.Magazine.Any(e => e.MagazineId == id);
        }
    }
}
