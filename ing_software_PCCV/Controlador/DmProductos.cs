using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Controlador
{
    public class DmProductos
    {

        private DtProductos oDt = new DtProductos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = oDt.mostrar();
            return tabla;
        }

        public void Editar(string id, string nombre, string descripcion, string precio, string stock, string talla)
        {
            oDt.Editar(Convert.ToInt16(id), nombre, descripcion,, Convert.ToDouble(precio), Convert.ToInt16(stock), talla);
        }

    }
}
