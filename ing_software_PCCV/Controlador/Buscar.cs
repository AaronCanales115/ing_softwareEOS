using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Datos;
namespace Controlador
{
    public class Buscar
    {
       public void Filtrar(DataGridView data, string busqueda)
        {
            Conexion con = new Conexion();
            try
            {
                SqlCommand sql = new SqlCommand("SPFiltroBusqueda",con.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = busqueda;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }
        }
    }
}
/*
CREATE PROCEDURE SPFiltroBusqueda 
@Filtro as nvarchar(100)
AS
BEGIN
	 SELECT idProducto as ID
       ,Producto.Nombre
	   ,Producto.Descripcion
	   ,Producto.Precio
	   ,Producto.Stock
	   ,Producto.Talla
	   ,Categoria.Nombre
	   ,EstadoProducto.Estado
       FROM Producto, Categoria,EstadoProducto
	   WHERE Producto.idCategoria = Categoria.idCategoria AND Producto.Estado = EstadoProducto.idEstadoProducto AND Producto.Nombre LIKE @Filtro + '%'
END
GO
*/
