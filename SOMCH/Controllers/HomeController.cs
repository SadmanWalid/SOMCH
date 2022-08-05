using Microsoft.AspNetCore.Mvc;
using SOMCH.Models;
using System.Diagnostics;
using SOMCH.Data;

namespace SOMCH.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult RegUserInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegUserInfo(RegUserInfo user)
        {
            //bool status = false;
            //string message = "";

            //var errors = ModelState.Values.SelectMany(v => v.Errors);

            if (ModelState.IsValid)
            {
                bool isExist = IsMobileNumberExist(user.MobileNumber);

                if (isExist)
                {
                    using (var context = new Registration2Context())
                    {
                        var retrievedPassword = context.RegUserInfos.Where(a => a.MobileNumber == user.MobileNumber).SingleOrDefault();
                        if (retrievedPassword != null)
                        {
                            if (retrievedPassword.Password == user.Password)
                            {
                                //status = true;
                                //message = "Login Successful";
                                return RedirectToAction("Dashboard");
                            }
                            else
                            {
                                //status = false;
                                //message = "Invalid password";
                                TempData["error"] = "Incorrect username or Password";
                            }
                        }
                    }
                }
                else
                {
                    //status = false;
                    //message = "Invalid username";
                    TempData["error"] = "Incorrect username or Password";
                }
            }
            else
            {
                //status = false;
                //message = "Invalid Request";
                TempData["error"] = "Invalid request";
            }

            //ViewBag.Status = status;
            //ViewBag.Message = message;

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult PatientWorkList()
        {
            return View();
        }

        public IActionResult IdCard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [NonAction]
        public bool IsMobileNumberExist(string? mobileNumber)
        {
            using (var context = new Registration2Context())
            {
                var retrievedMobileNumber = context.RegUserInfos.Where(a => a.MobileNumber == mobileNumber).FirstOrDefault();
                return retrievedMobileNumber != null;
            }
        }
    }
}