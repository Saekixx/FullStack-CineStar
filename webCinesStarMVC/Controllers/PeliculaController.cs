using Microsoft.AspNetCore.Mvc;

namespace webCinesStarMVC.Controllers
{
    public class PeliculaController : Controller
    {
        dao.daoPelicula daoPelicula = new dao.daoPelicula();
        public IActionResult verPeliculas( int id )
        {
            return View( daoPelicula.getVerPeliculas(id) );
        }

        public IActionResult verPelicula(int idPelicula)
        {
            ViewBag.Pelicula = daoPelicula.getVerPelicula(idPelicula);
            return View( daoPelicula.getVerPelicula(idPelicula) );
        }
    }
}
