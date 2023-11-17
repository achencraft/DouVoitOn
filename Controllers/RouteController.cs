using DouVoitOn.Data;
using DouVoitOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DouVoitOn.Controllers
{
    public class RouteController : Controller
    {
        private readonly ILogger<RouteController> _logger;
        private readonly ApplicationDbContext _context;

        public List<Lieu> _lieux { get; set; } = default!;

        public RouteController(ILogger<RouteController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            _lieux = await _context.Lieux.ToListAsync();
            ViewBag.Lieux = _lieux;
            return View("/Views/Contribuer/Route/Index.cshtml");
        }

 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}