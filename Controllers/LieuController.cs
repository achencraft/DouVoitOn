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

        public IActionResult Index()
        {
            return View("/Views/Contribuer/Lieu/Index.cshtml");
        }

        public IActionResult New()
        {
            return View("/Views/Contribuer/Lieu/New.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> New(IFormCollection fc)
        {
            Lieu nouveau_lieu = new Lieu();
            Pays pays;
            int new_id = 0;
            Enum.TryParse<Pays>(fc["pays"], out pays);

            if (_context.Lieux.Count() > 0)
            {
                new_id = _context.Lieux.Max(lieu => lieu.Id) + 1;
            }

            nouveau_lieu.Id = new_id;
            nouveau_lieu.Nom = fc["Nom"];
            nouveau_lieu.Pays = pays;
            nouveau_lieu.Ville = fc["Ville"];
            nouveau_lieu.Adresse = fc["Adresse"];
            nouveau_lieu.Description = fc["Description"];
            nouveau_lieu.Latitude = fc["Latitude"];
            nouveau_lieu.Longitude = fc["Longitude"];

            _context.Lieux.Add(nouveau_lieu);
            _context.SaveChanges();

            return View("/Views/Contribuer/Lieu/Edit.cshtml", new_id);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Lieu lieu = new Lieu();
            List<Lieu> lieux = await _context.Lieux.ToListAsync();
            if (lieux.Where(x => x.Id == id).Count() > 0)
            {
                lieu = lieux.Where(x => x.Id == id).First();
            }

            ViewBag.lieu = lieu;

            return View("/Views/Contribuer/Lieu/Edit.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}