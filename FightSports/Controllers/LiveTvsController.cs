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
    public class LiveTvsController : Controller
    {
        private readonly CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public LiveTvsController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context)
        {
            _context = context;
        }

        // GET: LiveTvs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LiveTv.ToListAsync());
        }

        // GET: LiveTvs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liveTv = await _context.LiveTv
                .FirstOrDefaultAsync(m => m.LiveTvId == id);
            if (liveTv == null)
            {
                return NotFound();
            }

            return View(liveTv);
        }

        // GET: LiveTvs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LiveTvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LiveTvId,LivePath,LiveTitle")] LiveTv liveTv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liveTv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(liveTv);
        }

        // GET: LiveTvs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liveTv = await _context.LiveTv.FindAsync(id);
            if (liveTv == null)
            {
                return NotFound();
            }
            return View(liveTv);
        }

        // POST: LiveTvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LiveTvId,LivePath,LiveTitle")] LiveTv liveTv)
        {
            if (id != liveTv.LiveTvId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liveTv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiveTvExists(liveTv.LiveTvId))
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
            return View(liveTv);
        }

        // GET: LiveTvs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liveTv = await _context.LiveTv
                .FirstOrDefaultAsync(m => m.LiveTvId == id);
            if (liveTv == null)
            {
                return NotFound();
            }

            return View(liveTv);
        }

        // POST: LiveTvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liveTv = await _context.LiveTv.FindAsync(id);
            _context.LiveTv.Remove(liveTv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiveTvExists(int id)
        {
            return _context.LiveTv.Any(e => e.LiveTvId == id);
        }
    }
}
