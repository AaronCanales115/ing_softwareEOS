using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Datos
{
   public class DtProveedor
    {
        private Conexion conexion = new Conexion();
        public void MostrarProveedores(DataGridView data)
        {
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("SPVerProveedores", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            data.DataSource = tab;
        }
        public string AgregarProveedores(string nombre, string ruc, string ubicacion, int tipo)
        {
            try
            {
                SqlParameter res;
                DataTable tab = new DataTable();
                SqlCommand sql = new SqlCommand("SPAgregarProveedor", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Nombre", nombre);
                sql.Parameters.AddWithValue("@RUC", ruc);
                sql.Parameters.AddWithValue("@Ubicacion", ubicacion);
                sql.Parameters.AddWithValue("@Tipo", tipo);
                res = sql.Parameters.AddWithValue("@Res", "");
                sql.Parameters["@Res"].Direction = ParameterDirection.Output;
                sql.ExecuteNonQuery();
                Console.WriteLine(res.Value.ToString());
                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "ERROR";
            }
        }
            public string ModificarProveedores(int id,string nombre, string ruc, string ubicacion)
           {
            try
            {
                SqlParameter res;
                DataTable tab = new DataTable();
                SqlCommand sql = new SqlCommand("SPModificarProveedor", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@idProveedor", id);
                sql.Parameters.AddWithValue("@Nombre", nombre);
                sql.Parameters.AddWithValue("@RUC", ruc);
                sql.Parameters.AddWithValue("@Ubicacion", ubicacion);
                res = sql.Parameters.AddWithValue("@res", "");
                sql.Parameters["@res"].Direction = ParameterDirection.Output;
                sql.ExecuteNonQuery();
                Console.WriteLine(res.Value.ToString());
                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "ERROR";
            }

        }
        public void EliminarProveedores(int id)
        {
            try
            {
                SqlParameter res;
                DataTable tab = new DataTable();
                SqlCommand sql = new SqlCommand("SPEliminarProveedor", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@idProveedor", id);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
            }

        }
        public string Factura()
        {
            string result = "";
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SPNumeroFactura", conexion.AbrirConexion());

            tabla.Clear();
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);

            if (tabla.Rows.Count > 0)
            {
                result = Convert.ToString(tabla.Rows[0][0]);
            }
            Console.WriteLine(result);
            return result;
            
        }
    }
}
