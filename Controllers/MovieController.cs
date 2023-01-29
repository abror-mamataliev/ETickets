using ETickets.Data;
using ETickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Movie> allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
