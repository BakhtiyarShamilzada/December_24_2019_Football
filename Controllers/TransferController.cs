using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using December_24_2019_Football.DAL;
using December_24_2019_Football.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace December_24_2019_Football.Controllers
{
    public class TransferController : Controller
    {
        private readonly AppDbContext _context;
        public TransferController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Teams = _context.Teams,
                Transfers = _context.Transfers.Include(t => t.FootballPlayer)
            };
            return View(homeViewModel);
        }

        public IActionResult Create()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Teams = _context.Teams
            };
            return View(homeViewModel);
        }
    }
}