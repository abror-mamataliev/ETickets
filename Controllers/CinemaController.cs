using ETickets.Data;
using ETickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Cinema> allCinemas= await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
