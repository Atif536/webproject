using Microsoft.AspNetCore.Mvc;

namespace Sunfiit_2._0v.Controllers
{
    public class feature : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult products()
        {
            return View();
        }
        public IActionResult categories()
        {
            return View();
        }
        public IActionResult review()
        {
            return View();
        }
    }
}
