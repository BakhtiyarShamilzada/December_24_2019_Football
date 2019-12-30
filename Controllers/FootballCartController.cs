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

        public async Task<IActionResult> Create()
        {
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
                GameTimes = _context.GameTimes
            };
            return View(homeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeViewModel homeViewModel)
        {
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

        HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayers,
                CartId = footballCart.CartId,
                FootballPlayerId = footballCart.FootballPlayerId,
                GameTimeId = footballCart.GameTimeId,
                GameTimes = footballPlayerGameTimes.Select(fpgt => fpgt.GameTime)
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