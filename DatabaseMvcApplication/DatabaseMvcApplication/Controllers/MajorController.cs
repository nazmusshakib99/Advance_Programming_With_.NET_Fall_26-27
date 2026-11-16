using DatabaseMvcApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMvcApplication.Controllers
{
    public class MajorController(Fall2627Context _context) : Controller
    {
        public IActionResult Index()
        {

            var major = _context.Majors.ToList();
            //var major = _context.Majors.Where(e=>e.TotalTutionFee/e.TotalCredit>5500).ToList();
            return View(major);
        }
    }
}
