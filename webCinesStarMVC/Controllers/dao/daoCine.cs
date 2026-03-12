using webCinesStarMVC.Models;
using Microsoft.Data.SqlClient;

namespace webCinesStarMVC.Controllers.dao
{
    public class daoCine
    {
        bd.clsBD clsbd = new bd.clsBD("cnCineStar");
        internal List<Cine> getVerCines()
        {
            clsbd.Sentencia( "sp_getCines" );
            return new Cine().getList( clsbd.getRegistros() ); 
        }

        internal Cine getCine(int idCine)
        {
            clsbd.Sentencia( "sp_getCine", new SqlParameter("@id", idCine));
            Cine Cine = new Cine();
            Cine.setRegistro( clsbd.getRegistro() );
            return Cine;
        }

        internal dynamic getCineTarifas(int idCine)
        {
            clsbd.Sentencia( "sp_getCineTarifas", new SqlParameter("@idCine", idCine) );
            return new CineTarifa().getList( clsbd.getRegistros() );
        }

        internal dynamic getCinePeliculas(int idCine)
        {
            clsbd.Sentencia( "sp_getCinePeliculas", new SqlParameter("@idCine", idCine) );
            return new CinePelicula().getList( clsbd.getRegistros() );
        }
    }
}
