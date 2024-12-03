using Microsoft.AspNetCore.Mvc;

namespace TiendaPersonalizada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
