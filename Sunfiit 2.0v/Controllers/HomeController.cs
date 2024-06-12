using Microsoft.AspNetCore.Mvc;
using Sunfiit_2._0v.Models;
using System.Diagnostics;

namespace Sunfiit_2._0v.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly db db1;

        public HomeController(ILogger<HomeController> logger, db db1)
        {
            _logger = logger;
            this.db1 = db1;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult savedata(login log1)

        {
            if (ModelState.IsValid)
            {
                try
                {
                    db1.Add(log1);
                    db1.SaveChanges();
                    TempData["output"] =db1.login2.ToList();
                    ViewBag.message = "successfuly save";
                    TempData["data"] = "success";
                }
                catch (Exception ex)
                {
                    ViewBag.message = "failde  save";
                    TempData["data"] = "faild";
                }
               



            }
            TempData.Keep();
            return View(Privacy);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
