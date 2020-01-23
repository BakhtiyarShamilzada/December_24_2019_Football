using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using December_24_2019_Football.DAL;
using December_24_2019_Football.Models;
using December_24_2019_Football.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using static December_24_2019_Football.Utilities.Utilities;

namespace December_24_2019_Football.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _env;
        public AjaxController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilterFootballCart(DateTime date1, DateTime date2, int positionId, int cartId)
        {
            IEnumerable<FootballCart> footballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart).Include(fc => fc.GameTime);

            if (date1.ToString("dd.MM.yyyy") != "01.01.0001")
            {
                footballCarts = footballCarts.Where(fb => fb.GameTime.Date >= date1);
            }
            if (date2.ToString("dd.MM.yyyy") != "01.01.0001")
            {
                footballCarts = footballCarts.Where(fb => fb.GameTime.Date <= date2);
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
            RemoveImage(_env.WebRootPath, footballPlayer.Image);
            _context.FootballPlayers.Remove(footballPlayer);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FootballPlayers = _context.FootballPlayers.Include(fb => fb.Position).Include(fp => fp.Team),
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
                FootballCarts = _context.FootballCarts.Include(fc => fc.FootballPlayer).Include(fc => fc.Cart).Include(fc => fc.GameTime),
                Positions = _context.Positions
            };
            return PartialView("_FootballCartsPartialView", homeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteByGameTimeId(int GameTimeId)
        {
            GameTime gameTime = await _context.GameTimes.FindAsync(GameTimeId);
            _context.GameTimes.Remove(gameTime);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            HomeViewModel homeViewModel = new HomeViewModel
            {
                GameTimes = _context.GameTimes.Include(fc => fc.Stadium),
                Teams = _context.Teams
            };
            return PartialView("_GameTimesPartialView", homeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteByStadiumId(int StadiumId)
        {
            Stadium stadium = await _context.Stadiums.FindAsync(StadiumId);
            RemoveImage(_env.WebRootPath, stadium.Image);
            _context.Stadiums.Remove(stadium);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;
            return PartialView("_StadiumsPartialView", _context.Stadiums);
        }

        [HttpPost]
        public IActionResult LoadSelectGameTimesByFootballPlayerId(int FootballPlayerId)
        {
            IEnumerable<FootballPlayerGameTime> footballPlayerGameTimes = _context.FootballPlayerGameTimes.Include(btct => btct.GameTime).Where(bct => bct.FootballPlayerId == FootballPlayerId);
            return PartialView("_SelectGameTimesPartialView", footballPlayerGameTimes);
        }

        [HttpPost]
        public IActionResult LoadSelectTeamsByTeamId(int TeamId)
        {
            IEnumerable<Team> teams = _context.Teams.Where(t => t.Id != TeamId);
            return PartialView("_SelectTeamsPartialView", teams);
        }

        [HttpPost]
        public IActionResult LoadFootballersByTeamId(int TeamId)
        {
            IEnumerable<FootballPlayer> footballPlayers = _context.FootballPlayers.Where(f => f.TeamId == TeamId);
            return PartialView("_TeamsPartialView", footballPlayers);
        }

        [HttpPost]
        public IActionResult LoadTeamsByTeamId(int TeamId)
        {
            IEnumerable<Team> teams = _context.Teams.Where(t => t.Id != TeamId);
            return PartialView("_SelectTeamsPartialView", teams);
        }

        public async Task<IActionResult> CreateTransfers(string demo)
        {
            JObject jObject = JObject.Parse(demo);
            int footballerId = (int)jObject["footballerId"];
            int team1Id = (int)jObject["team1Id"];
            int team2Id = (int)jObject["team2Id"];
            decimal price = (decimal)jObject["price"];

            Transfer transfer = new Transfer
            {
                FootballPlayerId = footballerId,
                OldTeamId = team1Id,
                NewTeamId = team2Id,
                Price = price
            };

            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(footballerId);
            if (footballPlayer == null) return NotFound();

            footballPlayer.TeamId = team2Id;

            await _context.Transfers.AddAsync(transfer);
            await _context.SaveChangesAsync();

            IEnumerable<FootballPlayer> footballPlayers = _context.FootballPlayers.Where(f => f.TeamId == team1Id);
            return PartialView("_TeamsPartialView", footballPlayers);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteByTransferId(int TransferId)
        {
            Transfer transfer = await _context.Transfers.FindAsync(TransferId);
            if (transfer == null) return NotFound();

            FootballPlayer footballPlayer = await _context.FootballPlayers.FindAsync(transfer.FootballPlayerId);
            if (footballPlayer == null) return NotFound();

            footballPlayer.TeamId = transfer.OldTeamId;

            _context.Transfers.Remove(transfer);
            await _context.SaveChangesAsync();
            TempData["Operation"] = true;

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Teams = _context.Teams,
                Transfers = _context.Transfers.Include(t => t.FootballPlayer)
            };
            return PartialView("_TransfersPartialView", homeViewModel);
        }
    }
}