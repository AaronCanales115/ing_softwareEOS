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

        public void Editar(string id, string nombre, string descripcion, string precio, string stock, string talla, string categoria, string estado, string usuario, string resultado)
        {
            oDt.Editar(Convert.ToInt16(id), nombre, descripcion, Convert.ToDecimal(precio), Convert.ToInt16(stock), talla, Convert.ToInt16(categoria), Convert.ToInt16(estado), Convert.ToInt16(usuario), resultado);
        }

        public void eliminar(string id, string usuario, string resultado)
        {
            oDt.Eliminar(Convert.ToInt16(id), Convert.ToInt16(usuario), resultado);
        }
    }
}
