using Microsoft.AspNetCore.Mvc;

namespace TiendaPersonalizada.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
