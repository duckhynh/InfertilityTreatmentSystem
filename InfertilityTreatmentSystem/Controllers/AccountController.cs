using InfertilityTreatmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfertilityTreatmentSystem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "123456")
                {
                    
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Login");
            }

            return View(model);
        }
        public IActionResult ForgotPassword()
        {
            return Content("Forgot Password page not implemented.");
        }
    }
}
