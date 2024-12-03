using Microsoft.AspNetCore.Mvc;

namespace TiendaPersonalizada.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
