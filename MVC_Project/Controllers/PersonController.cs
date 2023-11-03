using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{

    public class PersonController : Controller
    {
        public IActionResult GiaiPhuongTrinh()
        {
            // Hiển thị view để nhập các giá trị a, b, c
            return View();
        }

        [HttpPost]
        public IActionResult GiaiPhuongTrinh(double a, double b, double c)
        {
            // Gọi logic giải phương trình bậc 2 từ controller
            double delta = b * b - 4 * a * c;
            double? x1 = null;
            double? x2 = null;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
            }

            // Sử dụng ViewBag để truyền dữ liệu đến view
            ViewBag.X1 = x1;
            ViewBag.X2 = x2;

            return View();
        }
    }
}
