using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DtProductos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT idProducto as ID ,Producto.Nombre ,Producto.Descripcion ,Producto.Precio ,Producto.Stock ,Producto.Talla,EstadoProducto.Estado FROM Producto,EstadoProducto WHERE Producto.Estado = EstadoProducto.idEstadoProducto";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
           
        }

        public void Editar(int id, string nombre, string descripcion, double precio, int stock, string talla, int categoria, int estado, int usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPActualizarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.Parameters.AddWithValue("@Talla", talla);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            comando.Parameters.AddWithValue("@Estado", stock);
            comando.Parameters.AddWithValue("@Usuario", talla);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
