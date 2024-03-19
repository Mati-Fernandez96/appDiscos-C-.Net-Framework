using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using Datos;

namespace datos 
{
    public class DiscoDatos
    {
        public List<Disco> listar()
        {
            List<Disco>lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();  
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; 

            try
            {
                conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Genero, T.TipoEdicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id;";
                comando.Connection = conexion;  

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];

                    //if (!(lector["UrlImagen"] is DBNull))
                      //  aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Id = (int)lector["IdEstilo"];
                    aux.Genero.Genero = (string)lector["Genero"]; 
                    aux.TiposEdicion = new TiposEdicion();
                    aux.TiposEdicion.id = (int)lector["IdTipoEdicion"]; 
                    aux.TiposEdicion.tipoEdicion = (string)lector["TipoEdicion"];




                    lista.Add(aux);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consultaSql = "INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, idTipoEdicion, IdEstilo, UrlImagenTapa) VALUES (@Titulo, @FechaLanzamiento, @CantidadCanciones, @IdTipoEdicion, @idEstilo, @UrlImagen)";
                datos.setearConsulta(consultaSql);

                datos.setearParametro("@Titulo", nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones", nuevo.CantidadCanciones);
                // Asegúrate de que los siguientes dos campos sean los ID correctos para idEdicionDatos e idEstiloDatos.
                // Estoy asumiendo que "nuevo.TiposEdicion" y "nuevo.Genero" tienen una propiedad "Id" que corresponde al valor que debe ir en la base de datos.
                datos.setearParametro("@idTipoEdicion", nuevo.TiposEdicion.id); // Asume que TiposEdicion tiene una propiedad Id
                datos.setearParametro("@IdEstilo", nuevo.Genero.Id); // Asume que Estilo tiene una propiedad Id
                datos.setearParametro("@UrlImagen", nuevo.UrlImagen);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Disco modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento, CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlImagen, IdEstilo = @idEstiloDatos, IdTipoEdicion = @idEdicionDatos where Id = @Id ");
                datos.setearParametro("@Titulo",modificar.Titulo);
                datos.setearParametro("@FechaLanzamiento",modificar.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones", modificar.CantidadCanciones);
                datos.setearParametro("@UrlImagen", modificar.UrlImagen);
                datos.setearParametro("@idEstiloDatos", modificar.Genero.Id);
                datos.setearParametro("@idEdicionDatos", modificar.TiposEdicion.id);
                datos.setearParametro("@Id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update DISCOS set Activo = where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Genero, T.TipoEdicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ";
                if (campo == "Cantidad canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones = " + filtro;
                            break;
                    }
                }
                else if (campo == "Titulo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Titulo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Titulo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Titulo like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    //if (!(lector["UrlImagen"] is DBNull))
                    //  aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Id = (int)datos.Lector["IdEstilo"];
                    aux.Genero.Genero = (string)datos.Lector["Genero"];
                    aux.TiposEdicion = new TiposEdicion();
                    aux.TiposEdicion.id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TiposEdicion.tipoEdicion = (string)datos.Lector["TipoEdicion"];




                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    
  
}
