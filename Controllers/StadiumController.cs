using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using December_24_2019_Football.DAL;
using static December_24_2019_Football.Extension.IFileFormExtension;
using static December_24_2019_Football.Utilities.Utilities;
using December_24_2019_Football.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace December_24_2019_Football.Controllers
{
    public class StadiumController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _env;
        public StadiumController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Stadiums);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Stadium stadium)
        {
            if (stadium.Photo == null)
            {
                ModelState.AddModelError("Photo", "Choose image !");
                return View(stadium);
            }

            if (!stadium.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "The file must be an image !");
                return View(stadium);
            }

            if (stadium.Photo.IsLessThan(2))
            {
                ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                return View(stadium);
            }

            // Save
            string fileName = await stadium.Photo.Save(_env.WebRootPath, "Stadium");
            stadium.Image = fileName;
            await _context.Stadiums.AddAsync(stadium);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Stadium stadium = await _context.Stadiums.FindAsync(id);
            if (stadium == null) return NotFound();
            return View(stadium);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Stadium stadium)
        {
            if (!ModelState.IsValid) return View(stadium);

            Stadium stadiumFromDb = await _context.Stadiums.FindAsync(stadium.Id);

            if (stadium.Photo != null)
            {
                if (!stadium.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "The file must be an image !");
                    return View(stadium);
                }

                if (stadium.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                    return View(stadium);
                }

                // Remove old image
                RemoveImage(_env.WebRootPath, stadiumFromDb.Image);

                // Save new image
                stadiumFromDb.Image = await stadium.Photo.Save(_env.WebRootPath, "Stadium");
            }

            stadiumFromDb.Name = stadium.Name;
            stadiumFromDb.Address = stadium.Address;
            await _context.SaveChangesAsync();

            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }
    }
}