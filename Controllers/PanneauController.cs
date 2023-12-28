using DouVoitOn.Data;
using DouVoitOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DouVoitOn.Controllers
{
    public class PanneauController : Controller
    {
        private readonly ILogger<PanneauController> _logger;
        private readonly ApplicationDbContext _context;

        public List<Lieu> _lieux { get; set; } = default!;
        public List<TypePanneau> _typePanneaux { get; set; } = default!;

        public PanneauController(ILogger<PanneauController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Panneau> panneaux = await _context.Panneaux.ToListAsync();
            ViewBag.panneaux = panneaux;
            return View("/Views/Contribuer/Panneau/Index.cshtml");
        }

        public async Task<IActionResult> New()
        {
            _lieux = await _context.Lieux.ToListAsync();
            _typePanneaux = await _context.TypesPanneau.ToListAsync();
            ViewBag.Lieux = _lieux;
            ViewBag.TypesPanneaux = _typePanneaux;
            return View("/Views/Contribuer/Panneau/New.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> New(PanneauInput p)
        {
            Panneau panneau = new Panneau();

            int new_id = 0;
            if (_context.Panneaux.Count() > 0)
            {
                new_id = _context.Panneaux.Max(x => x.Id) + 1;
            }
            panneau.Id = new_id;
            panneau.Activated = false;
            panneau.Latitude = p.panneau.Latitude;
            panneau.Longitude = p.panneau.Longitude;
            panneau.Adresse = p.panneau.Adresse;
            panneau.Ville = p.panneau.Ville;
            panneau.Pays = p.panneau.Pays;
            panneau.Description = p.panneau.Description;

            if (p.Lieux != null)
            {
                foreach (var lieu in p.Lieux)
                {

                    if (lieu.Id != -1)
                    {
                        LieuPanneau lp = new LieuPanneau();
                        if (_context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).Count() > 0)
                        {
                            lp.typePanneau = _context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).First();
                        }
                        if (_context.Lieux.Where(x => x.Id == lieu.Lieu.Id).Count() > 0)
                        {
                            lp.Lieu = _context.Lieux.Where(x => x.Id == lieu.Lieu.Id).First();
                        }

                        lp.Panneau = panneau;
                        lp.Distance = lieu.Distance;
                        lp.NomRoute = lieu.NomRoute == null ? "" : lieu.NomRoute;

                        _context.LieuPanneau.Add(lp);
                    }
                }
            }

            _context.Panneaux.Add(panneau);
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Panneau");
        }

        public async Task<IActionResult> Edit(int id)
        {
            PanneauInput pi = new PanneauInput();
            _lieux = await _context.Lieux.ToListAsync();
            _typePanneaux = await _context.TypesPanneau.ToListAsync();
            ViewBag.Lieux = _lieux;
            ViewBag.TypesPanneaux = _typePanneaux;

            var panneau = _context.Panneaux.Find(id);
            if (panneau != null)
            {
                pi.panneau = panneau;
                ViewBag.panneau = panneau;
                
                var lieux = _context.LieuPanneau
                    .Include(l => l.Lieu)
                    .Include(p => p.Panneau)
                    .Include(t => t.typePanneau)
                    .Where(lp => lp.Panneau.Id == id);
                if (lieux.Count() > 0)
                {
                    ViewBag.lieuxpanneau = lieux.ToList();
                }
            }
            else
            {
                return RedirectToAction("Index", "Panneau");
            }
            return View("/Views/Contribuer/Panneau/Edit.cshtml", pi);



        }



        [HttpPost]
        public async Task<IActionResult> Edit(PanneauInput p)
        {


            var panneau = _context.Panneaux.Find(p.panneau.Id);
            if (panneau != null)
            {
                panneau.Latitude = p.panneau.Latitude;
                panneau.Longitude = p.panneau.Longitude;
                panneau.Pays = p.panneau.Pays;
                panneau.Ville = p.panneau.Ville;
                panneau.Adresse = p.panneau.Adresse;
                panneau.Description = p.panneau.Description;
                panneau.Activated = p.panneau.Activated;
            }


            if (p.Lieux != null)
            {

               /* if(_context.LieuPanneau.Where(x => x.Panneau.Id == p.panneau.Id).Any())
                {
                    foreach(var item in _context.LieuPanneau.Where(x => x.Panneau.Id == p.panneau.Id))
                    {
                        _context.LieuPanneau.Remove(item);
                    }
                }*/

                foreach (var lieu in p.Lieux)
                {

                    if (lieu.Lieu.Id != -1)
                    {
                        if (lieu.Id != 0 && _context.LieuPanneau.Where(x => x.Id == lieu.Id).Any())
                        {
                            //à modifier
                            LieuPanneau lp = _context.LieuPanneau.Where(x => x.Id == lieu.Id).First();
                            if (_context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).Count() > 0)
                            {
                                lp.typePanneau = _context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).First();
                            }
                            if (_context.Lieux.Where(x => x.Id == lieu.Lieu.Id).Count() > 0)
                            {
                                lp.Lieu = _context.Lieux.Where(x => x.Id == lieu.Lieu.Id).First();
                            }

                            lp.Panneau = panneau;
                            lp.Distance = lieu.Distance;
                            lp.NomRoute = lieu.NomRoute == null ? "" : lieu.NomRoute;
                            lp.Activated = false;

                        }
                        else
                        {
                            //à créer
                            LieuPanneau lp = new LieuPanneau();
                            if (_context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).Count() > 0)
                            {
                                lp.typePanneau = _context.TypesPanneau.Where(x => x.Id == lieu.typePanneau.Id).First();
                            }
                            if (_context.Lieux.Where(x => x.Id == lieu.Lieu.Id).Count() > 0)
                            {
                                lp.Lieu = _context.Lieux.Where(x => x.Id == lieu.Lieu.Id).First();
                            }

                            lp.Panneau = panneau;
                            lp.Distance = lieu.Distance;
                            lp.NomRoute = lieu.NomRoute == null ? "" : lieu.NomRoute;
                            lp.Activated = false;

                            _context.LieuPanneau.Add(lp);
                        }
                           
                    }
                    else
                    {
                        //à supprimer

                        if (_context.LieuPanneau.Where(x => x.Id == lieu.Id).Any())
                        {
                            foreach (var item in _context.LieuPanneau.Where(x => x.Id == lieu.Id))
                            {
                                item.ASupprimer = true;
                                item.Activated = false;
                                //_context.LieuPanneau.Remove(item);
                            }
                        }
                    }
                }
            }


            _context.SaveChanges();


            //ajouter maj lieux

            return RedirectToAction("Index", "Panneau");
        }

        public async Task<IActionResult> View(int id)
        {
            var panneau = _context.Panneaux.Find(id);
            if (panneau != null)
            {
                var lieux = _context.LieuPanneau
                    .Include(l => l.Lieu)
                    .Include(t => t.typePanneau)
                    .Where(lp => lp.Panneau.Id == id);
                if (lieux.Count() > 0)
                {
                    
                    ViewBag.lieux = lieux;
                }
                ViewBag.panneau = panneau;

            }
            else
            {
                return RedirectToAction("Index", "Panneau");
            }
            return View("/Views/Contribuer/Panneau/View.cshtml", panneau);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}