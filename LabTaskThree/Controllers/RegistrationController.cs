using LabTaskThree.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTaskThree.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (student.StudentId == "STU001")
            {
                ModelState.AddModelError("StudentId", "Student ID STU001 is already registered");
            }

            if (!ModelState.IsValid)
            {
                return View(student);
            }

            ViewBag.Message = "Registration successful for " + student.Name;
            return View("Success", student);
        }
    }
}
