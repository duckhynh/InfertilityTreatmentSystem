using Microsoft.AspNetCore.Mvc;

namespace InfertilityTreatmentSystem.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Information()
        {
            return View(Information);
        }
    }
}
