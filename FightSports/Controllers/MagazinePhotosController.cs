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
    public class MagazinePhotosController : Controller
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public MagazinePhotosController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        //public IActionResult GetMagazinePhotosById(int? id)
        //{
        //    ViewBag.test = _context.MagazinePhotos.Where(x => x.MagazineId == id);
        //    return Json(null);
        //}

        // GET: MagazinePhotos
        public async Task<IActionResult> Index()
        {
            var cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext = _context.MagazinePhotos.Include(m => m.Magazine);
            return View(await cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext.ToListAsync());
        }

        // GET: MagazinePhotos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazinePhotos = await _context.MagazinePhotos
                .Include(m => m.Magazine)
                .FirstOrDefaultAsync(m => m.MagazinePhotoId == id);
            if (magazinePhotos == null)
            {
                return NotFound();
            }

            return View(magazinePhotos);
        }

        // GET: MagazinePhotos/Create
        public IActionResult Create()
        {
            ViewData["MagazineId"] = new SelectList(_context.Magazine, "MagazineId", "MagazineFirstPhotoPath");
            return View();
        }

        // POST: MagazinePhotos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MagazinePhotos magazinePhotos)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(magazinePhotos.FormFile.FileName));
                magazinePhotos.MagazinePhotoPath = "/" + Path.GetFileName(magazinePhotos.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await magazinePhotos.FormFile.CopyToAsync(stream);
                }

                _context.Add(magazinePhotos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MagazineId"] = new SelectList(_context.Magazine, "MagazineId", "MagazineFirstPhotoPath", magazinePhotos.MagazineId);
            return View(magazinePhotos);
        }

        // GET: MagazinePhotos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazinePhotos = await _context.MagazinePhotos.FindAsync(id);
            if (magazinePhotos == null)
            {
                return NotFound();
            }
            ViewData["MagazineId"] = new SelectList(_context.Magazine, "MagazineId", "MagazineFirstPhotoPath", magazinePhotos.MagazineId);
            return View(magazinePhotos);
        }

        // POST: MagazinePhotos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MagazinePhotos magazinePhotos)
        {
            if (id != magazinePhotos.MagazinePhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(magazinePhotos.FormFile.FileName));
                magazinePhotos.MagazinePhotoPath = "/" + Path.GetFileName(magazinePhotos.FormFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await magazinePhotos.FormFile.CopyToAsync(stream);
                }


                try
                {
                    _context.Update(magazinePhotos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MagazinePhotosExists(magazinePhotos.MagazinePhotoId))
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
            ViewData["MagazineId"] = new SelectList(_context.Magazine, "MagazineId", "MagazineFirstPhotoPath", magazinePhotos.MagazineId);
            return View(magazinePhotos);
        }

        // GET: MagazinePhotos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magazinePhotos = await _context.MagazinePhotos
                .Include(m => m.Magazine)
                .FirstOrDefaultAsync(m => m.MagazinePhotoId == id);
            if (magazinePhotos == null)
            {
                return NotFound();
            }

            return View(magazinePhotos);
        }

        // POST: MagazinePhotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var magazinePhotos = await _context.MagazinePhotos.FindAsync(id);
            _context.MagazinePhotos.Remove(magazinePhotos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MagazinePhotosExists(int id)
        {
            return _context.MagazinePhotos.Any(e => e.MagazinePhotoId == id);
        }
    }
}
