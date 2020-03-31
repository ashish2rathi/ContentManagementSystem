using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogPost()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}