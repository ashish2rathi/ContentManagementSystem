using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
