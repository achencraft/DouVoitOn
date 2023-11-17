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


        public PanneauController(ILogger<PanneauController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View("/Views/Contribuer/Panneau/Index.cshtml");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}