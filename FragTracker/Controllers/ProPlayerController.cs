using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FragTracker.Data;
using FragTracker.Models;

namespace FragTracker.Controllers
{
    public class ProPlayersController : Controller
    {
        private readonly AppDbContext _context;

        public ProPlayersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var players = await _context.ProPlayers.ToListAsync();
            return View(players);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nickname,Team,Game,Rating")] ProPlayer player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }
    }
}