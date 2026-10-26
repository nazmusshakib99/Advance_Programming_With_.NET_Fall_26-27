using Microsoft.AspNetCore.Mvc;

namespace ViewExample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(int StudentId, string FullName,
     string Email, string Phone, string Gender,
     DateTime DateOfBirth, string Address, string Department)
        {
            ViewBag.Message = "Student Registered Successfully!";
            return View();
        }
    }
}
