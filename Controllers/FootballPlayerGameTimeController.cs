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
    public class FootballPlayerGameTimeController : Controller
    {
        private readonly AppDbContext _context;
        public FootballPlayerGameTimeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(int id)
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Include(fp => fp.Position),
                GameTimeId = id
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeViewModel homeViewModel)
        {
            string[] footballPlayersId = homeViewModel.FootballPlayersId.Split(",");
            foreach (var id in footballPlayersId)
            {
               try
                {
                    int footballPlayerId = Convert.ToInt32(id);

                    //save
                    FootballPlayerGameTime footballPlayerGameTime = new FootballPlayerGameTime
                    {
                        GameTimeId = homeViewModel.GameTimeId,

                        FootballPlayerId = footballPlayerId
                    };
                    await _context.FootballPlayerGameTimes.AddAsync(footballPlayerGameTime);
                    await _context.SaveChangesAsync();
                }
                catch
                {

                }
            }
            TempData["Operation"] = true;
            return RedirectToAction("Index", "Gametime");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            GameTime gameTime = await _context.GameTimes.FindAsync(id);
            if(gameTime == null) return NotFound();
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Where(fpg => fpg.GameTimeId == id).Include(fpg => fpg.FootballPlayer);
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers,
                Positions = _context.Positions,
                FootballPlayerGameTimes = footballPlayerGameTimes,
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, HomeViewModel homeViewModel)
        {
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimesFromDb = _context.FootballPlayerGameTimes.Where(fg => fg.GameTimeId == id);
            foreach (var item in footballPlayerGameTimesFromDb)
            {
                _context.FootballPlayerGameTimes.Remove(item);
            }

            string[] footballPlayersId = homeViewModel.FootballPlayersId.Split(",");
            foreach (var Id in footballPlayersId)
            {
                try
                {
                    int footballPlayerId = Convert.ToInt32(Id);

                    //save
                    FootballPlayerGameTime footballPlayerGameTime = new FootballPlayerGameTime
                    {
                        GameTimeId = id,

                        FootballPlayerId = footballPlayerId
                    };
                    await _context.FootballPlayerGameTimes.AddAsync(footballPlayerGameTime);
                    await _context.SaveChangesAsync();
                }
                catch
                {

                }
            }
            TempData["Operation"] = true;
            return RedirectToAction("Index", "Gametime");
        }
    }
}