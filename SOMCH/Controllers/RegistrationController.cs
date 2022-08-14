using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SOMCH.Data;
using SOMCH.Models;


namespace SOMCH.Controllers
{
    public class RegistrationController : Controller
    {
        public Registration2Context DbContext { get; }

        public RegistrationController(Registration2Context _context)
        {
            this.DbContext = _context;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        // POST: RegPatientRegInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration([Bind("AgeInDay,AgeInMonth,AgeInYear,BloodGroupId,Dob,Email,GenderId,PatientName")] RegPatientRegInfo regPatientRegInfo)
        {
            if (ModelState.IsValid)
            {

                DbContext.Add(regPatientRegInfo);
                DbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientId"] = new SelectList(DbContext.RegPatientAccounts, "Id", "Id", regPatientRegInfo.PatientId);
            ViewData["PatientAccountId"] = new SelectList(DbContext.RegPatientAccounts, "Id", "Id", regPatientRegInfo.PatientAccountId);
            return View(regPatientRegInfo);
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
