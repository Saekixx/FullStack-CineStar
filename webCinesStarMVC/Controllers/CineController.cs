using Microsoft.AspNetCore.Mvc;

namespace webCinesStarMVC.Controllers
{
    public class CineController : Controller
    {
        dao.daoCine daoCine = new dao.daoCine(); 

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult verCines()
        {
            return View( daoCine.getVerCines() );
        }

        public IActionResult verCine( int idCine )
        {
            ViewBag.Cine = daoCine.getCine( idCine );
            ViewBag.lstCineTarifas = daoCine.getCineTarifas( idCine );
            ViewBag.lstCinePeliculas = daoCine.getCinePeliculas( idCine );
            return View();
        }
    }
}
