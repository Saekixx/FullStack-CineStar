using Microsoft.AspNetCore.Mvc;

namespace webCinesStarMVC.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult verPeliculas( int id )
        {
            return View();
        }

        public IActionResult verPelicula(int idPelicula)
        {
            return View();
        }
    }
}
