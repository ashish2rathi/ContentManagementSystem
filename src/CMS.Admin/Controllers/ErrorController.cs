using Microsoft.AspNetCore.Mvc;

namespace CMS.Admin.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
