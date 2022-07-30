using Microsoft.AspNetCore.Mvc;

namespace SOMCH.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult RegisteredPatientList()
        {
            return View();

        }

        public IActionResult IdCard()
        {
            return View();
        }
    }
}
