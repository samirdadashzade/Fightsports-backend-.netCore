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
    public class MelumatsController : Controller
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public MelumatsController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Melumats
        public async Task<IActionResult> Index()
        {
            var cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext = _context.Melumat.Include(m => m.SportCategory);
            return View(await cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext.ToListAsync());
        }

        // GET: Melumats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumat = await _context.Melumat
                .Include(m => m.SportCategory)
                .FirstOrDefaultAsync(m => m.MelumatId == id);
            if (melumat == null)
            {
                return NotFound();
            }

            return View(melumat);
        }

        // GET: Melumats/Create
        public IActionResult Create()
        {
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName");
            return View();
        }

        // POST: Melumats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Melumat melumat)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(melumat.FormFile.FileName));
                melumat.MelumatPhotoPath = "/" + Path.GetFileName(melumat.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await melumat.FormFile.CopyToAsync(stream);
                }

                _context.Add(melumat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", melumat.SportCategoryId);
            return View(melumat);
        }

        // GET: Melumats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumat = await _context.Melumat.FindAsync(id);
            if (melumat == null)
            {
                return NotFound();
            }
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", melumat.SportCategoryId);
            return View(melumat);
        }

        // POST: Melumats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MelumatId,MelumatTxt,MelumatPhotoPath,MelumatAdress,SportCategoryId")] Melumat melumat)
        {
            if (id != melumat.MelumatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(melumat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MelumatExists(melumat.MelumatId))
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
            ViewData["SportCategoryId"] = new SelectList(_context.SportCategories, "SportCategoryId", "SportCategoryName", melumat.SportCategoryId);
            return View(melumat);
        }

        // GET: Melumats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumat = await _context.Melumat
                .Include(m => m.SportCategory)
                .FirstOrDefaultAsync(m => m.MelumatId == id);
            if (melumat == null)
            {
                return NotFound();
            }

            return View(melumat);
        }

        // POST: Melumats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var melumat = await _context.Melumat.FindAsync(id);
            _context.Melumat.Remove(melumat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MelumatExists(int id)
        {
            return _context.Melumat.Any(e => e.MelumatId == id);
        }
    }
}
