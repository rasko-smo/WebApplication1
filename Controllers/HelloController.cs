using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _db;

        // コンテキストを注入
        public HelloController(MyContext db)
        {
            _db = db;
        }

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

        public IActionResult List()
        {
            // データベースから取得した結果をテンプレートに渡す
            var books = _db.Books;
            return View(books);
        }
    }
}
