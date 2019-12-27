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
    public class GameTimeController : Controller
    {
        private readonly AppDbContext _context;
        public GameTimeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                GameTimes = _context.GameTimes.Include(fc => fc.Team).Include(fc => fc.Stadium),
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Teams = _context.Teams,
                Stadiums = _context.Stadiums
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeViewModel homeViewModel)
        {
            //save
            GameTime gameTime = new GameTime
            {
                TeamId = homeViewModel.TeamId,
                StadiumId = homeViewModel.StadiumId,
                Date = homeViewModel.Date
            };
            await _context.GameTimes.AddAsync(gameTime);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create", "FootballPlayerGameTime", new { id = gameTime.Id });
        }
    }
}