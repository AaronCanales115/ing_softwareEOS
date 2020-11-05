using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Controlador
{
    public class DmComprasE
    {
        public void GuardarCompraE(string usuario, string Factura,string cantidad, string total, string Proveedor, string idProducto)
        {
            DtComprasE e = new DtComprasE();
            e.GuardarCompraE(Convert.ToInt32(usuario),Factura, Convert.ToInt32(cantidad), Convert.ToDecimal(total), Convert.ToInt32(Proveedor), Convert.ToInt32(idProducto));
        }
    }
}
