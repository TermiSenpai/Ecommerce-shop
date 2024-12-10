using Microsoft.AspNetCore.Mvc;

namespace TiendaPersonalizada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Action for generic errors
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml"); // Specify the shared view explicitly
        }

        // Action for 404 errors
        public IActionResult Error404()
        {
            return View("~/Views/Shared/Error404.cshtml"); // Specify the shared view explicitly
        }


    }
}
