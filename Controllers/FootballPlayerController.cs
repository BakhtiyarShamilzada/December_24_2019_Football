using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using December_24_2019_Football.DAL;
using December_24_2019_Football.Models;
using December_24_2019_Football.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace December_24_2019_Football.Controllers
{
    public class FootballPlayerController : Controller
    {
        private readonly AppDbContext _context;
        public FootballPlayerController(AppDbContext context)
        {
            _context = context;
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
            //save
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