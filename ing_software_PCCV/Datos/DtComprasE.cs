using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class DtComprasE
    {
        private Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void GuardarCompraE(int usuario,string Factura, int cantidad, decimal total, int Proveedor, int idProducto,decimal PrecioC,decimal PrecioV)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPAgregarCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@NFactura", Factura);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@idProveedor", Proveedor);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@PrecioCompra", PrecioC);
            comando.Parameters.AddWithValue("@PrecioVenta", PrecioV);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
