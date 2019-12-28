using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using December_24_2019_Football.DAL;
using static December_24_2019_Football.Extension.IFileFormExtension;
using static December_24_2019_Football.Utilities.Utilities;
using December_24_2019_Football.Models;
using December_24_2019_Football.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace December_24_2019_Football.Controllers
{
    public class FootballPlayerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _env;
        public FootballPlayerController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Include(fb => fb.Position),
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            ViewBag.Position = _context.Positions;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FootballPlayer footballPlayer)
        {
            if (footballPlayer.Photo == null)
            {
                ModelState.AddModelError("Photo", "Choose image !");
                return View(footballPlayer);
            }

            if (!footballPlayer.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "The file must be an image !");
                return View(footballPlayer);
            }

            if (footballPlayer.Photo.IsLessThan(2))
            {
                ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                return View(footballPlayer);
            }

            //save
            string fileName = await footballPlayer.Photo.Save(_env.WebRootPath, "FootballPlayer");
            footballPlayer.Image = fileName;

            await _context.FootballPlayers.AddAsync(footballPlayer);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(id);
            if (footballPlayer == null) return NotFound();
            ViewBag.Position = _context.Positions;
            return View(footballPlayer);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, FootballPlayer footballPlayer)
        {
            if (!ModelState.IsValid) return View(footballPlayer);
            FootballPlayer footballPlayerFromDb = await _context.FootballPlayers.FindAsync(footballPlayer.Id);

            if (footballPlayer.Photo != null)
            {
                if (!footballPlayer.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "The file must be an image !");
                    return View(footballPlayer);
                }

                if (footballPlayer.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                    return View(footballPlayer);
                }

                // Remove old image
                RemoveImage(_env.WebRootPath, footballPlayerFromDb.Image);

                // Save new image
                footballPlayerFromDb.Image = await footballPlayer.Photo.Save(_env.WebRootPath, "FootballPlayer");
            }

            footballPlayerFromDb.Firstname = footballPlayer.Firstname;
            footballPlayerFromDb.Lastname = footballPlayer.Lastname;
            footballPlayerFromDb.Age = footballPlayer.Age;
            footballPlayerFromDb.PositionId = footballPlayer.PositionId;

            await _context.SaveChangesAsync();

            TempData["Operation"] = true;
            ViewBag.Position = _context.Positions;
            return RedirectToAction(nameof(Index));
        }
    }
}