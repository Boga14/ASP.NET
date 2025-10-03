using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StaticPageController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
    }
}