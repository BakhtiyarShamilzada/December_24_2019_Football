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
                FootballPlayers = _context.FootballPlayers.Include(fp => fp.Position).Include(fp => fp.Team),
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Positions = _context.Positions,
                Teams = _context.Teams,
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeViewModel homeViewModel)
        {
            if (homeViewModel.FootballPlayer.Photo == null)
            {
                ModelState.AddModelError("Photo", "Choose image !");
                return View(homeViewModel);
            }

            if (!homeViewModel.FootballPlayer.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "The file must be an image !");
                return View(homeViewModel);
            }

            if (homeViewModel.FootballPlayer.Photo.IsLessThan(2))
            {
                ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                return View(homeViewModel);
            }

            //save
            string fileName = await homeViewModel.FootballPlayer.Photo.Save(_env.WebRootPath, "FootballPlayer");
            homeViewModel.FootballPlayer.Image = fileName;

            await _context.FootballPlayers.AddAsync(homeViewModel.FootballPlayer);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(id);
            if (footballPlayer == null) return NotFound();
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Positions = _context.Positions,
                Teams = _context.Teams,
                FootballPlayer = footballPlayer
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, HomeViewModel homeViewModel)
        {
            if (!ModelState.IsValid) return View(homeViewModel);
            FootballPlayer footballPlayerFromDb = await _context.FootballPlayers.FindAsync(id);

            if (homeViewModel.FootballPlayer.Photo != null)
            {
                if (!homeViewModel.FootballPlayer.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "The file must be an image !");
                    return View(homeViewModel);
                }

                if (homeViewModel.FootballPlayer.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "The size of the image must be less than 2 MB !");
                    return View(homeViewModel);
                }

                // Remove old image
                RemoveImage(_env.WebRootPath, footballPlayerFromDb.Image);

                // Save new image
                footballPlayerFromDb.Image = await homeViewModel.FootballPlayer.Photo.Save(_env.WebRootPath, "FootballPlayer");
            }

            footballPlayerFromDb.Firstname = homeViewModel.FootballPlayer.Firstname;
            footballPlayerFromDb.Lastname = homeViewModel.FootballPlayer.Lastname;
            footballPlayerFromDb.Age = homeViewModel.FootballPlayer.Age;
            footballPlayerFromDb.PositionId = homeViewModel.FootballPlayer.PositionId;
            footballPlayerFromDb.TeamId = homeViewModel.FootballPlayer.TeamId;

            await _context.SaveChangesAsync();

            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }
    }
}