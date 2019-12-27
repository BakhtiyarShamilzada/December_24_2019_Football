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
                FootballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart),
                Positions = _context.Positions
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayers
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
                Date = homeViewModel.Date
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
            Cart cart = await _context.Carts.FindAsync(footballCart.CartId);
            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(footballCart.FootballPlayerId);
            if (footballCart == null) return NotFound();
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayers,
                CartId = cart.Id,
                FootballPlayerId = footballPlayer.Id,
                Date = footballCart.Date
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
            footballCartFromDb.Date = homeViewModel.Date;

            await _context.SaveChangesAsync();

            TempData["Operation"] = true;
            return RedirectToAction(nameof(Index));
        }
    }
}