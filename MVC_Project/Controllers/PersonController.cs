using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x1 = 0;
            double x2 = 0;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
            }

            ViewBag.X1 = x1;
            ViewBag.X2 = x2;

            return View();
        }
    }
}
