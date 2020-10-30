using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Controlador
{
    public class DmVisualizarProductos
    {

        private DtVisualizarProductos oDt = new DtVisualizarProductos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = oDt.mostrar();
            return tabla;
        }


    }
}
