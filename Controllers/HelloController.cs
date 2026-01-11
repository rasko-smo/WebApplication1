using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MethodName()
        {
            return Content("こんにちは、世界！！");
        }

        public IActionResult Show()
        {
            ViewBag.Message = "こんにちは、世界！！！";
            return View();
        }
    }
}
