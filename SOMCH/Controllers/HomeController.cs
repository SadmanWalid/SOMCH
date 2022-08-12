using Microsoft.AspNetCore.Mvc;
using SOMCH.DTOs;
using SOMCH.Models;
using SOMCH.Repositories;
using System.Diagnostics;

namespace SOMCH.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginRepository loginRepo;

        public HomeController(ILogger<HomeController> logger, ILoginRepository loginRepo)
        {
            _logger = logger;
            this.loginRepo = loginRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginDTO user)
        {

            if (!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                var userToBeLoggedIn = loginRepo.FindUser(user.Username);
             
                //checking creadentials
                if (userToBeLoggedIn != null)
                {
                    if (userToBeLoggedIn.Password != user.Password)
                    {
                        ModelState.AddModelError("Password", "Incorrect username or Password.");
                        //userToBeLoggedIn.ErrorMessages.Add("Password", "Incorrect username or Password.");
                        return View(user);
                    }
                    else
                    {
                        return RedirectToAction("Dashboard");
                    }
                }
                else
                {
                    ModelState.AddModelError("AccountNotExist", "The Username or Password Number that you’ve entered doesn’t match any account.");
                    return View(user);
                }

            }
        }



        //}

        public IActionResult Dashboard()
        {
            return View();
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