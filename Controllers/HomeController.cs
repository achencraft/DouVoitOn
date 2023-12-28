using DouVoitOn.Data;
using DouVoitOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DouVoitOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public List<Lieu> _lieux { get; set; } = default!;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            _lieux = await _context.Lieux.Where(l => l.Activated).ToListAsync();
            ViewBag.Lieux = _lieux;
            return View();
        }

        public LieuEtPanneaux GetLieu(int id)
        {
            LieuEtPanneaux lep = new LieuEtPanneaux();
            lep.lieu = _context.Lieux.Find(id);
            if (lep.lieu != null)
            {
                var panneaux = _context.LieuPanneau
                    .Include(p => p.Panneau)
                    .Include(t => t.typePanneau)
                    .Where(lp => lp.Lieu.Id == id);
                if (panneaux.Count() > 0)
                {
                    lep.panneaux = panneaux.ToList();
                }
                
            }
            return lep;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}