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
    public class SportCategoriesController : Controller
    {
        private readonly CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public SportCategoriesController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context)
        {
            _context = context;
        }

        // GET: SportCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.SportCategories.ToListAsync());
        }

        // GET: SportCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportCategories = await _context.SportCategories
                .FirstOrDefaultAsync(m => m.SportCategoryId == id);
            if (sportCategories == null)
            {
                return NotFound();
            }

            return View(sportCategories);
        }

        // GET: SportCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SportCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportCategoryId,SportCategoryName")] SportCategories sportCategories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sportCategories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sportCategories);
        }

        // GET: SportCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportCategories = await _context.SportCategories.FindAsync(id);
            if (sportCategories == null)
            {
                return NotFound();
            }
            return View(sportCategories);
        }

        // POST: SportCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportCategoryId,SportCategoryName")] SportCategories sportCategories)
        {
            if (id != sportCategories.SportCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sportCategories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportCategoriesExists(sportCategories.SportCategoryId))
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
            return View(sportCategories);
        }

        // GET: SportCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportCategories = await _context.SportCategories
                .FirstOrDefaultAsync(m => m.SportCategoryId == id);
            if (sportCategories == null)
            {
                return NotFound();
            }

            return View(sportCategories);
        }

        // POST: SportCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sportCategories = await _context.SportCategories.FindAsync(id);
            _context.SportCategories.Remove(sportCategories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportCategoriesExists(int id)
        {
            return _context.SportCategories.Any(e => e.SportCategoryId == id);
        }
    }
}
