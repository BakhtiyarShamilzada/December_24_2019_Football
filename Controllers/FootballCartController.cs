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
    public class FootballCartController : Controller
    {
        private readonly AppDbContext _context;
        public FootballCartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart).Include(fc => fc.GameTime),
                Positions = _context.Positions
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayerGameTimes.Select(fg => fg.FootballPlayer).ToHashSet(),
                GameTimes = _context.GameTimes
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeViewModel homeViewModel)
        {
            IEnumerable<FootballCart> footballCarts = _context.FootballCarts.Where(fc => fc.FootballPlayerId == homeViewModel.FootballPlayerId && fc.GameTimeId == homeViewModel.GameTimeId);
            int countRed = footballCarts.Where(fc => fc.CartId == 1).Count();
            int countYellow = footballCarts.Where(fc => fc.CartId == 2).Count();
            if (countRed != 0)
            {
                homeViewModel = new HomeViewModel
                {
                    Carts = _context.Carts,
                    FootballPlayers = _context.FootballPlayerGameTimes.Select(fg => fg.FootballPlayer).ToHashSet(),
                    GameTimes = _context.GameTimes
                };
                ModelState.AddModelError("", "The player already has a red card");
                return View(homeViewModel);
            }

            if(countYellow == 2)
            {
                homeViewModel = new HomeViewModel
                {
                    Carts = _context.Carts,
                    FootballPlayers = _context.FootballPlayerGameTimes.Select(fg => fg.FootballPlayer).ToHashSet(),
                    GameTimes = _context.GameTimes
                };
                ModelState.AddModelError("", "The player already has 2 yellow card");
                return View(homeViewModel);
            }

            if(countYellow == 1 && homeViewModel.CartId == 1)
            {
                FootballCart footballCartFromDb = footballCarts.FirstOrDefault();
                footballCartFromDb.CartId = 1;

                await _context.SaveChangesAsync();
                TempData["Operation"] = true;
                return RedirectToAction(nameof(Index));
            }

            //save
            FootballCart footballCart = new FootballCart
            {
                FootballPlayerId = homeViewModel.FootballPlayerId,
                CartId = homeViewModel.CartId,
                GameTimeId = homeViewModel.GameTimeId
            };
            await _context.FootballCarts.AddAsync(footballCart);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            FootballCart footballCart = await _context.FootballCarts.FindAsync(id);
            if (footballCart == null) return NotFound();
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Include(btct => btct.GameTime).Where(bct => bct.FootballPlayerId == footballCart.FootballPlayerId);

            List<FootballPlayer> footballPlayers = _context.FootballPlayers.ToList();
            footballPlayers.Clear();
            foreach (var item in _context.FootballPlayerGameTimes)
            {
                footballPlayers.Add(await _context.FootballPlayers.FirstAsync(fp => fp.Id == item.FootballPlayerId));
            }

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = footballPlayers,
                CartId = footballCart.CartId,
                FootballPlayerId = footballCart.FootballPlayerId,
                GameTimeId = footballCart.GameTimeId,
                GameTimes = footballPlayerGameTimes.Select(fpgt => fpgt.GameTime),
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, HomeViewModel homeViewModel)
        {
            if (!ModelState.IsValid) return View(homeViewModel);
            FootballCart footballCartFromDb = await _context.FootballCarts.FindAsync(id);

            footballCartFromDb.FootballPlayerId = homeViewModel.FootballPlayerId;
            footballCartFromDb.CartId = homeViewModel.CartId;
            footballCartFromDb.GameTimeId = homeViewModel.GameTimeId;

            await _context.SaveChangesAsync();

            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }
    }
}