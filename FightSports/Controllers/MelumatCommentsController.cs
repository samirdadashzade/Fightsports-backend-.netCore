using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FightSports.Models;

namespace FightSports.Controllers
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class MelumatCommentsController : Controller
    {
        private readonly CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public MelumatCommentsController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context)
        {
            _context = context;
        }

        public IActionResult GetMelumatCommentsById(int? id)
        {
            var comms = _context.MelumatComments.Where(x => x.MelumatId == id);
            return Json(comms);
        }

        // GET: MelumatComments
        public async Task<IActionResult> Index()
        {
            var cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext = _context.MelumatComments.Include(m => m.Melumat);
            return View(await cUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext.ToListAsync());
        }

        // GET: MelumatComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumatComments = await _context.MelumatComments
                .Include(m => m.Melumat)
                .FirstOrDefaultAsync(m => m.MelumatCommentId == id);
            if (melumatComments == null)
            {
                return NotFound();
            }

            return View(melumatComments);
        }

        // GET: MelumatComments/Create
        public IActionResult Create()
        {
            ViewData["MelumatId"] = new SelectList(_context.Melumat, "MelumatId", "MelumatId");
            return View();
        }

        // POST: MelumatComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] MelumatComments melumatComments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(melumatComments);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            ViewData["MelumatId"] = new SelectList(_context.Melumat, "MelumatId", "MelumatId", melumatComments.MelumatId);
            return Json(melumatComments);
        }

        // GET: MelumatComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumatComments = await _context.MelumatComments.FindAsync(id);
            if (melumatComments == null)
            {
                return NotFound();
            }
            ViewData["MelumatId"] = new SelectList(_context.Melumat, "MelumatId", "MelumatId", melumatComments.MelumatId);
            return View(melumatComments);
        }

        // POST: MelumatComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MelumatCommentId,MelumatCommentAuthorName,MelumatCommentTxt,MelumatCommentDate,MelumatId")] MelumatComments melumatComments)
        {
            if (id != melumatComments.MelumatCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(melumatComments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MelumatCommentsExists(melumatComments.MelumatCommentId))
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
            ViewData["MelumatId"] = new SelectList(_context.Melumat, "MelumatId", "MelumatId", melumatComments.MelumatId);
            return View(melumatComments);
        }

        // GET: MelumatComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melumatComments = await _context.MelumatComments
                .Include(m => m.Melumat)
                .FirstOrDefaultAsync(m => m.MelumatCommentId == id);
            if (melumatComments == null)
            {
                return NotFound();
            }

            return View(melumatComments);
        }

        // POST: MelumatComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var melumatComments = await _context.MelumatComments.FindAsync(id);
            _context.MelumatComments.Remove(melumatComments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MelumatCommentsExists(int id)
        {
            return _context.MelumatComments.Any(e => e.MelumatCommentId == id);
        }
    }
}
