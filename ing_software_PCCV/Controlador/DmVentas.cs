using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Data;

namespace Controlador
{
    public class DmVentas
    {
        private DtVentas oDt = new DtVentas();

        public string agregarVenta(string NFactura, string usuario, string nombreC, string apellidoC, string cantidadProductos, string descuento, string subTotal, string total)
        {
           string re = oDt.agregarVenta(NFactura, Convert.ToInt16(usuario), nombreC, apellidoC, Convert.ToInt16(cantidadProductos), Convert.ToDecimal(descuento), Convert.ToDecimal(subTotal), Convert.ToDecimal(total));
            return re;
        }

        public void ventaProducto(string idProducto, string idv, string cantidad)
        {
            oDt.ventaProducto(Convert.ToInt16(idProducto), Convert.ToInt16(idv), Convert.ToInt16(cantidad));
        }
        public void verVentas(DataGridView datos, string Factura)
        {
            oDt.VerVentas(datos,Convert.ToInt32(Factura));
            datos.Columns["ID"].Visible = false;
        }
        public DataTable VerProductosVentas(string ID)
        {
            
            DataTable dt = new DataTable();
           
            dt = oDt.VerProductos(Convert.ToInt32(ID));
           

            return dt;
        }
        public void CancelarF(string Ids,string Cantidades)
        {
            oDt.Cancelar(Convert.ToInt32(Ids), Convert.ToInt32(Cantidades));
        }
    }
}
