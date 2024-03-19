using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Xml.Linq;
using dominio;

namespace datos
{
    public class EdicionDatos
    {
        public List<TiposEdicion> listar()
        {
            List<TiposEdicion> lista = new List<TiposEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, TipoEdicion From TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TiposEdicion aux = new TiposEdicion();
                    aux.id = (int)datos.Lector["Id"];
                    aux.tipoEdicion = (string)datos.Lector["TipoEdicion"];

                    lista.Add(aux);
                }

                return lista;
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
    }
}

