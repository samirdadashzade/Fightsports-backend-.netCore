using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using WebApplication1.Data;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace WebApplication1.Controllers
{
    [Authorize]
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class PhotosController : Controller
    {
        public ApplicationDbContext _context;
        public IHostingEnvironment _hostingEnvironment;

        public PhotosController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            var ApplicationDbContext = _context.Photos.Include(p => p.News);
            return View(await ApplicationDbContext.ToListAsync());
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
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsName");
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
                var date = DateTime.UtcNow.AddHours(4);
                var photoAddDate = photos.PhotoAddedData = date.ToString("yyyy-MM-dd','HH:mm:ss", CultureInfo.InvariantCulture);

                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "images");


                using (_context)
                {
                    foreach (var file in photos.FormFile)
                    {

                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);

                        var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
                        await file.CopyToAsync(s);
                        photos.PhotoPath = fileName;

                        _context.Photos.Add(photos);
                       


                        //if (file != null && file.Length > 0)
                        //{
                        //    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);

                        //    var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
                        //    await file.CopyToAsync(s);
                        //    photos.PhotoPath = fileName;

                        //    _context.Photos.Add(photos);
                        //    await _context.SaveChangesAsync();
                        //}
                    }

                    _context.Database.OpenConnection();
                    try
                    {
                        _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.photos ON");
                        await _context.SaveChangesAsync();
                        _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.photos OFF");
                    }
                    finally
                    {
                        _context.Database.CloseConnection();
                    }
                    
                }


               

                return RedirectToAction(nameof(Index));



                //var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(photos.FormFile.FileName));
                //photos.PhotoPath = "/" + Path.GetFileName(photos.FormFile.FileName);

                //using (var stream = new FileStream(filePath, FileMode.Create))
                //{
                //    photos.FormFile.CopyTo(stream);
                //}
                //_context.Add(photos);
                //await _context.SaveChangesAsync();



                //foreach (var item in files)
                //{
                //    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(item.FileName));
                //    photos.PhotoPath = "/" + Path.GetFileName(item.FileName);

                //    _context.Add(photos);
                //    _context.SaveChanges();

                //}

                //foreach (IFormFile item in formFiles)
                //{
                //    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(item.FileName));
                //    photos.PhotoPath += "/" + Path.GetFileName(item.FileName);

                //    using (var stream = new FileStream(filePath, FileMode.Create))
                //    {
                //        item.CopyTo(stream);
                //    }

                //    _context.Add(photos);
                //    _context.SaveChanges();
                //}

                //if (formFiles != null && formFiles.Count > 0)
                //{
                //    string folderName = "Upload";
                //    string webRootPath = _hostingEnvironment.WebRootPath;
                //    string newPath = Path.Combine(webRootPath, folderName);
                //    if (!Directory.Exists(newPath))
                //    {
                //        Directory.CreateDirectory(newPath);
                //    }
                //    foreach (IFormFile item in formFiles)
                //    {
                //        if (item.Length > 0)
                //        {
                //            string fileName = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //            string fullPath = Path.Combine(newPath, fileName);
                //            photos.PhotoPath = "/" + Path.GetFileName(item.FileName);
                //            using (var stream = new FileStream(fullPath, FileMode.Create))
                //            {
                //                item.CopyTo(stream);
                //            }
                //        }
                //    }


                //}

                //return RedirectToAction(nameof(Index));
            }
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsName", photos.NewsId);
            return View(photos);
        }
        //[HttpPost]       
        //public async Task<IActionResult> Creates([FromBody] Photos photos)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(photos.FormFile.FileName));
        //        photos.PhotoPath = "/" + Path.GetFileName(item.FormFile.FileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await photos.FormFile.CopyToAsync(stream);
        //        }

        //        _context.Add(photos);
        //        await _context.SaveChangesAsync();
        //        //return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsName", photos.NewsId);
        //    return Json(photos);
        //}

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
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsName", photos.NewsId);
            return View(photos);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Photos photos)
        {
            if (id != photos.PhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var date = DateTime.UtcNow.AddHours(4);
                var photoAddDate = photos.PhotoAddedData = date.ToString("yyyy-MM-dd','HH:mm:ss", CultureInfo.InvariantCulture);

                //var filePath = Path.Combine(_hostingEnvironment.WebRootPath, Path.GetFileName(photos.FormFile.FileName));
                //photos.PhotoPath = "/" + Path.GetFileName(photos.FormFile.FileName);

                //using (var stream = new FileStream(filePath, FileMode.Create))
                //{
                //    await photos.FormFile.CopyToAsync(stream);
                //}

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
            ViewData["NewsId"] = new SelectList(_context.News, "NewsId", "NewsName", photos.NewsId);
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
