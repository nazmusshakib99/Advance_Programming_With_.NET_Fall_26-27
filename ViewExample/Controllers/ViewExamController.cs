using Microsoft.AspNetCore.Mvc;

namespace ViewExample.Controllers
{

   
    public class ViewExamController : Controller
    {
        public IActionResult List()
        {

            ViewBag.Message = "Hello from the student list";
            return View();
        }


        public IActionResult Item(int p1,int p2)
        {

            ViewBag.Start = p1;
            ViewBag.End =p2;
            return View(5);
        }
        public IActionResult CheckData(int id)
        {

            switch (id)
            {
                case 1:
                    return View(5);

                case 2:
                    return View(5.5);
                case 3:
                    return View("CheckData", "Sakib");

                case 4:
                    return View(new { id = 5, name = "Sakib" });
            }
            return View();
        }
    }
    
}
