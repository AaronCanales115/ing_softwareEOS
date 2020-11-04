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
       public void Filtrar(DataGridView data, string busqueda,int numero)
        {
            Conexion con = new Conexion();
            try
            {
                SqlCommand sql = new SqlCommand("SPFiltroBusqueda",con.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = busqueda;
                sql.Parameters.AddWithValue("@Numero",numero);
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

