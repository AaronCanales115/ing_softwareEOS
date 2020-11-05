using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Windows.Forms;
namespace Controlador
{
    public class DmProductos
    {

        private DtProductos oDt = new DtProductos();

        public void MostrarProductos(DataGridView dgv, string numero)
        {
           
            int valor = Convert.ToInt16(numero);
                oDt.mostrarProductos(dgv, valor);
                dgv.Columns["ID"].Visible = false;
        
         
        }

        public void Editar(string id, string nombre, string descripcion, string precio, string stock, string talla, string estado, string usuario)
        {
            oDt.Editar(Convert.ToInt16(id), nombre, descripcion, Convert.ToDecimal(precio), Convert.ToInt16(stock), talla, Convert.ToInt16(estado), Convert.ToInt16(usuario));
        }

        public void eliminar(string id, string usuario, string resultado)
        {
            oDt.Eliminar(Convert.ToInt16(id), Convert.ToInt16(usuario), resultado);
        }

        public void agregarProductoNuevo(string usuario, string nombre, string descripcion, string precio, string talla, string categoria, string estado, string NFactura, string cantidad, string total, string idProveedor)
        {
            decimal Total = Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
            oDt.agregarProductoNuevo(Convert.ToInt16(usuario), nombre, descripcion, Convert.ToDecimal(precio), talla, Convert.ToInt16(categoria), Convert.ToInt16(estado), NFactura, Convert.ToInt32(cantidad), Total, Convert.ToInt16(idProveedor));
        }
    }
}
