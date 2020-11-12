using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DtVentas
    {
        private Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
       
        public string agregarVenta(string NFactura, int usuario, string nombreC, string apellidoC, int cantidadProductos, decimal descuento, decimal subTotal, decimal total)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SPAgregarVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NFactura", NFactura);
                comando.Parameters.AddWithValue("@idUsuario", usuario);
                comando.Parameters.AddWithValue("@NombreC", nombreC);
                comando.Parameters.AddWithValue("@ApellidoC", apellidoC);
                comando.Parameters.AddWithValue("@cantidadProductos", cantidadProductos);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@subTotal", subTotal);
                comando.Parameters.AddWithValue("@Total", total);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                return "SI";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return "NO";
            }
        }

        public string ventaProducto(int idProducto, int idv, int cantidad)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SPVentaProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", idProducto);
                comando.Parameters.AddWithValue("@idv", idv);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                return "OK";
            }
            catch (Exception)
            {
                return "NO";
            }
        }

    }
}
