using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Controlador
{
    class DmVentas
    {
        private DtVentas oDt = new DtVentas();

        public void agregarVenta(string NFactura, string usuario, string nombreC, string apellidoC, string cantidadProductos, string descuento, string iva, string subTotal, string total)
        {
            oDt.agregarVenta(NFactura, Convert.ToInt16(usuario), nombreC, apellidoC, Convert.ToInt16(cantidadProductos), Convert.ToDecimal(descuento), Convert.ToDecimal(iva), Convert.ToDecimal(subTotal), Convert.ToDecimal(total));
        }

        public void ventaProducto(string idProducto, string idv, string cantidad)
        {
            oDt.ventaProducto(Convert.ToInt16(idProducto), Convert.ToInt16(idv), Convert.ToInt16(cantidad));
        }
    }
}
