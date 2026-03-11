using Microsoft.AspNetCore.Mvc;

namespace webCinesStarMVC.Controllers
{
    public class CineController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult verCines()
        {
            return View();
        }

        public IActionResult verCine( int idCine )
        {
            return View();
        }
    }
}
