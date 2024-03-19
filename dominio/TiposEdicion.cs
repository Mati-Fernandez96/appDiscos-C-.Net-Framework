using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace dominio
{
    public class TiposEdicion
    {
        public int id { get; set; }
        public string tipoEdicion { get; set; }

        

        public override string ToString()
        {
            return tipoEdicion;
        }
    }
}
