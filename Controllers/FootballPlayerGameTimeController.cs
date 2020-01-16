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

        public async Task<IActionResult> Create(int id)
        {
            GameTime gameTime = await _context.GameTimes.FindAsync(id);
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Where(f => f.TeamId == gameTime.Team1Id || f.TeamId == gameTime.Team2Id).Include(fp => fp.Position),
                Team1Id = gameTime.Team1Id,
                Team2Id = gameTime.Team2Id,
                Teams = _context.Teams.Where(t => t.Id == gameTime.Team1Id || t.Id == gameTime.Team2Id),
                PositionType1Id = gameTime.PositionType1Id,
                PositionType2Id = gameTime.PositionType2Id,
                PositionTypes = _context.PositionTypes
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, HomeViewModel homeViewModel)
        {
            GameTime gameTime = await _context.GameTimes.FindAsync(id);
            if (homeViewModel.FootballersIdPositionsId == null)
            {
                homeViewModel = new HomeViewModel
                {
                    FootballPlayers = _context.FootballPlayers.Where(f => f.TeamId == gameTime.Team1Id || f.TeamId == gameTime.Team2Id).Include(fp => fp.Position),
                    Team1Id = gameTime.Team1Id,
                    Team2Id = gameTime.Team2Id,
                    Teams = _context.Teams.Where(t => t.Id == gameTime.Team1Id || t.Id == gameTime.Team2Id),
                    PositionType1Id = gameTime.PositionType1Id,
                    PositionType2Id = gameTime.PositionType2Id,
                    PositionTypes = _context.PositionTypes.Where(pt => pt.Id == gameTime.PositionType1Id || pt.Id == gameTime.PositionType2Id)
                };
                ModelState.AddModelError("", "Choose football player");
                return View(homeViewModel);
            }
            string[] FootballersIdPositionsId = homeViewModel.FootballersIdPositionsId.Split(",");
            foreach (string footballersIdPositionsId in FootballersIdPositionsId)
            {
                string[] footballerIdPositionId = footballersIdPositionsId.Split("-");
                
                    try
                    {
                        int footballPlayerId = Convert.ToInt32(footballerIdPositionId[0]);
                        int positionId = Convert.ToInt32(footballerIdPositionId[1]);

                        //save
                        FootballPlayerGameTime footballPlayerGameTime = new FootballPlayerGameTime
                        {
                            GameTimeId = id,
                            FootballPlayerId = footballPlayerId,
                            FootballerPositionId = positionId
                        };
                        await _context.FootballPlayerGameTimes.AddAsync(footballPlayerGameTime);
                        await _context.SaveChangesAsync();
                    }
                    catch
                    {

                    }
            }

            // UPDATE POSITION TYPE
            gameTime.PositionType1Id = homeViewModel.PositionType1Id;
            gameTime.PositionType2Id = homeViewModel.PositionType2Id;

            // SAVE
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction("Index", "Gametime");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            GameTime gameTime = await _context.GameTimes.FindAsync(id);
            if(gameTime == null) return NotFound();
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Where(fpg => fpg.GameTimeId == id);
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Where(f => f.TeamId == gameTime.Team1Id || f.TeamId == gameTime.Team2Id),
                Team1Id = gameTime.Team1Id,
                Team2Id = gameTime.Team2Id,
                Teams = _context.Teams.Where(t => t.Id == gameTime.Team1Id || t.Id == gameTime.Team2Id),
                PositionType1Id = gameTime.PositionType1Id,
                PositionType2Id = gameTime.PositionType2Id,
                PositionTypes = _context.PositionTypes,
                FootballPlayerGameTimes = footballPlayerGameTimes
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, HomeViewModel homeViewModel)
        {
            GameTime gameTime = await _context.GameTimes.FindAsync(id);

            if (homeViewModel.FootballersIdPositionsId == null)
            {
                IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Where(fpg => fpg.GameTimeId == id).Include(fpg => fpg.FootballPlayer);
                homeViewModel = new HomeViewModel
                {
                    FootballPlayers = _context.FootballPlayers.Where(f => f.TeamId == gameTime.Team1Id || f.TeamId == gameTime.Team2Id),
                    Team1Id = gameTime.Team1Id,
                    Team2Id = gameTime.Team2Id,
                    Teams = _context.Teams.Where(t => t.Id == gameTime.Team1Id || t.Id == gameTime.Team2Id),
                    PositionType1Id = gameTime.PositionType1Id,
                    PositionType2Id = gameTime.PositionType2Id,
                    PositionTypes = _context.PositionTypes.Where(pt => pt.Id == gameTime.PositionType1Id || pt.Id == gameTime.PositionType2Id),
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

            string[] FootballersIdPositionsId = homeViewModel.FootballersIdPositionsId.Split(",");
            foreach (string footballersIdPositionsId in FootballersIdPositionsId)
            {
                string[] footballerIdPositionId = footballersIdPositionsId.Split("-");

                try
                {
                    int footballPlayerId = Convert.ToInt32(footballerIdPositionId[0]);
                    int positionId = Convert.ToInt32(footballerIdPositionId[1]);

                    //save
                    FootballPlayerGameTime footballPlayerGameTime = new FootballPlayerGameTime
                    {
                        GameTimeId = id,
                        FootballPlayerId = footballPlayerId,
                        FootballerPositionId = positionId
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

            // UPDATE POSITION TYPE
            gameTime.PositionType1Id = homeViewModel.PositionType1Id;
            gameTime.PositionType2Id = homeViewModel.PositionType2Id;

            // SAVE
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction("Index", "Gametime");
        }
    }
}