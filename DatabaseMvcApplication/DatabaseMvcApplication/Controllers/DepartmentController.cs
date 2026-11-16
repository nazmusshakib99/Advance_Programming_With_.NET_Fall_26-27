using DatabaseMvcApplication.Data;
using DatabaseMvcApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DatabaseMvcApplication.Controllers
{
    public class DepartmentController : Controller
    {
        private Fall2627Context _context;
        public DepartmentController(Fall2627Context context)
        {
            _context = context;

        }
        public IActionResult Index()
        {

            var departments = _context.Departments.ToList();
           
            return View(departments);
        }

        public IActionResult Delete(int did) {

            var dept = _context.Departments.Find(did);

            if (dept == null)
            {
                TempData["Error"] = "Invaild Id";
            }

            else
            {
                _context.Departments.Remove(dept);
                _context.SaveChanges();
                TempData["Success"] = "vaild Id";

            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View(new Department());
        }
        [HttpPost]
        public IActionResult Create(Department dept)
        {
            if (!ModelState.IsValid)
            {
                return View(dept);
            }
            else
            {
                _context.Departments.Add(dept);
                _context.SaveChanges();
                TempData["Success"] = "Added";
                return RedirectToAction("Index");
            }
            
        
        }


    

       public IActionResult Edit(int did)
        {
            var dept = _context.Departments.Find(did);
                return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(Department dept)
        {
            if (!ModelState.IsValid)
            {
                return View(dept);
            }
            else
            {
                _context.Departments.Update(dept);
                _context.SaveChanges();
                TempData["Success"] = "Updated";

                return RedirectToAction("Index");
            }

         
        }


    }
}
