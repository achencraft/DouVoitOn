using DouVoitOn.Data;
using DouVoitOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DouVoitOn.Controllers
{
    public class LieuController : Controller
    {
        private readonly ILogger<LieuController> _logger;
        private readonly ApplicationDbContext _context;

        public List<Lieu> _lieux { get; set; } = default!;

        public LieuController(ILogger<LieuController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Lieu> lieux = await _context.Lieux.ToListAsync();
            ViewBag.lieux = lieux;
            return View("/Views/Contribuer/Lieu/Index.cshtml");
        }

        public IActionResult New()
        {
            return View("/Views/Contribuer/Lieu/New.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> New(Lieu l)
        {
            
            int new_id = 0;
            if (_context.Lieux.Count() > 0)
            {
                new_id = _context.Lieux.Max(lieu => lieu.Id) + 1;
            }
            l.Id = new_id;
            l.Activated = false;
            _context.Lieux.Add(l);
            _context.SaveChanges();

            return RedirectToAction("Index", "Lieu");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var lieu = _context.Lieux.Find(id);
            if (lieu != null)
            {
                ViewBag.lieu = lieu;
            }
            else
            {
                return RedirectToAction("Index", "Lieu");
            }            
            return View("/Views/Contribuer/Lieu/Edit.cshtml",lieu);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Lieu l)
        {

            var lieu = _context.Lieux.Find(l.Id);
            if (lieu != null) 
            {
                lieu.Nom = l.Nom;
                lieu.Latitude = l.Latitude;
                lieu.Longitude = l.Longitude;
                lieu.Pays = l.Pays;
                lieu.Ville = l.Ville;
                lieu.Adresse= l.Adresse;
                lieu.Description = l.Description;
                lieu.Activated = l.Activated;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Lieu");
        }

        public async Task<IActionResult> View(int id)
        {
            var lieu = _context.Lieux.Find(id);
            if (lieu != null)
            {
                var panneaux = _context.LieuPanneau
                    .Include(p => p.Panneau)
                    .Include(t => t.typePanneau)
                    .Where(lp => lp.Lieu.Id == id);
                if (panneaux.Count() > 0)
                {
                    ViewBag.panneaux = panneaux;
                    ViewBag.lieu = lieu;
                }
            }
            else
            {
                return RedirectToAction("Index", "Lieu");
            }
            return View("/Views/Contribuer/Lieu/View.cshtml", lieu);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}