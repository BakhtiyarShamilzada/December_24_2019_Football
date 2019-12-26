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
    public class AjaxController : Controller
    {
        private readonly AppDbContext _context;
        public AjaxController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilterFootballCart(DateTime date1, DateTime date2, int positionId, int cartId)
        {
            IEnumerable<FootballCart> footballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart);

            if (date1.ToString("dd.MM.yyyy") != "01.01.0001")
            {
                footballCarts = footballCarts.Where(fb => fb.Date >= date1);
            }
            if (date2.ToString("dd.MM.yyyy") != "01.01.0001")
            {
                footballCarts = footballCarts.Where(fb => fb.Date <= date2);
            }
            if (positionId != 0)
            {
                footballCarts = footballCarts.Where(fb => fb.FootballPlayer.PositionId == positionId);
            }
            if (cartId != 0)
            {
                footballCarts = footballCarts.Where(fb => fb.CartId == cartId);
            }

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayers,
                FootballCarts = footballCarts,
                Positions = _context.Positions
            };
            return PartialView("_FootballCartsPartialView", homeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteByFootballPlayerId(int FootballPlayerId)
        {
            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(FootballPlayerId);
            _context.FootballPlayers.Remove(footballPlayer);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Include(fb => fb.Position),
            };
            return PartialView("_FootballPlayersPartialView", homeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteByFootballCartId(int FootballCartId)
        {
            FootballCart footballCart = await _context.FootballCarts.FindAsync(FootballCartId);
            _context.FootballCarts.Remove(footballCart);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Carts = _context.Carts,
                FootballPlayers = _context.FootballPlayers,
                FootballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart),
                Positions = _context.Positions
            };
            return PartialView("_FootballCartsPartialView", homeViewModel);
        }
    }
}