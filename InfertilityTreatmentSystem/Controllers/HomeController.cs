using _1.Models;
using InfertilityTreatmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InfertilityTreatmentSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
            public IActionResult Login()
            {
                return RedirectToAction("Login", "Account");
            }
        public IActionResult register()
        {
            return RedirectToAction("Register", "Account");
        }
    }
}
