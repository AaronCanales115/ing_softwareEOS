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
        public void MostrarProductosVentas(DataGridView dgv, string numero)
        {

            int valor = Convert.ToInt16(numero);
            oDt.mostrarProductos(dgv, valor);
            dgv.Columns["ID"].Visible = false;


        }

        public void Editar(string id, string nombre, string descripcion, string precioVenta,string precioCompra, string stock, string talla, string estado, string usuario)
        {
            oDt.Editar(Convert.ToInt16(id), nombre, descripcion, Convert.ToDecimal(precioVenta), Convert.ToDecimal(precioCompra), Convert.ToInt16(stock), talla, Convert.ToInt16(estado), Convert.ToInt16(usuario));
        }

        public void eliminar(string id, string usuario, string resultado)
        {
            oDt.Eliminar(Convert.ToInt16(id), Convert.ToInt16(usuario), resultado);
        }

        public string agregarProductoNuevo(string usuario, string nombre, string descripcion, string precioVenta, string precioCompra, string talla, string categoria, string estado, string NFactura, string cantidad, string idProveedor)
        {
            
            int us = Convert.ToInt16(usuario.Trim());
            int cat = Convert.ToInt16(categoria.Trim());
            decimal pre = Convert.ToDecimal(precioCompra.Trim());
           int cant =  Convert.ToInt32(cantidad.Trim());
            decimal tot = pre * cant;
          
            string val = oDt.agregarProductoNuevo(us, nombre, descripcion, Convert.ToDecimal(precioVenta), pre, talla, cat, Convert.ToInt32(estado), NFactura, Convert.ToInt32(cantidad), tot, Convert.ToInt16(idProveedor));
            return val;
        }
      
    }
}
