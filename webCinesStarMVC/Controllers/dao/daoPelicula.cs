
using Microsoft.Data.SqlClient;
using webCinesStarMVC.Models;

namespace webCinesStarMVC.Controllers.dao
{
    public class daoPelicula
    {
        bd.clsBD clsbd = new bd.clsBD("cnCineStart");
        internal List<Pelicula> getVerPeliculas(int idPelicula)
        {
            clsbd.Sentencia( "sp_getPeliculas", new SqlParameter("@idEstado", idPelicula) );
            return new Pelicula().getList( clsbd.getRegistros() );
        }

        internal Pelicula getVerPelicula(int id)
        {
            clsbd.Sentencia( "sp_getPelicula", new SqlParameter("@id", id) );
            return new Pelicula( clsbd.getRegistro() );
        }
    }
}
