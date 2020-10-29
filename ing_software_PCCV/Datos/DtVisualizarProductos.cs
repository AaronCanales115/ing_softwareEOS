using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DtVisualizarProductos
    {
        DataTable tabla = new DataTable();

        public DataTable mostrar()
        {
            tabla.Clear();
            return tabla;
        }
    }
}
