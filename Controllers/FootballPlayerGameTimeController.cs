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
        public async Task<IActionResult> Create(int id, HomeViewModel homeViewModel)
        {
            if (homeViewModel.FootballPlayersId == null)
            {
                homeViewModel = new HomeViewModel
                {
                    FootballPlayers = _context.FootballPlayers.Include(fp => fp.Position),
                    GameTimeId = id
                };
                ModelState.AddModelError("", "Choose football player");
                return View(homeViewModel);
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
                FootballPlayerGameTimes = footballPlayerGameTimes
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, HomeViewModel homeViewModel)
        {
            if (homeViewModel.FootballPlayersId == null)
            {
                IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Where(fpg => fpg.GameTimeId == id).Include(fpg => fpg.FootballPlayer);
                homeViewModel = new HomeViewModel
                {
                    FootballPlayers = _context.FootballPlayers,
                    Positions = _context.Positions,
                    FootballPlayerGameTimes = footballPlayerGameTimes
                };
                ModelState.AddModelError("", "Choose football player");
                return View(homeViewModel);
            }
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
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimess = _context.FootballPlayerGameTimes;
            IEnumerable<FootballCart> footballCarts = _context.FootballCarts;
            foreach (var item in footballCarts)
            {
                if(footballPlayerGameTimess.Where(fpg => fpg.FootballPlayerId == item.FootballPlayerId && fpg.GameTimeId == item.GameTimeId).Count() == 0)
                {
                    FootballCart footballCart = footballCarts.First(fc => fc.FootballPlayerId == item.FootballPlayerId && fc.GameTimeId == item.GameTimeId);
                    _context.FootballCarts.Remove(footballCart);
                }
            }
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction("Index", "Gametime");
        }
    }
}