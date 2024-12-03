using Microsoft.AspNetCore.Mvc;

namespace TiendaPersonalizada.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
