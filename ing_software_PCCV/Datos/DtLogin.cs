using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class DtLogin
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string LoginN(string User,string Pass,string IP)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SPLoginN";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@UserName", User);
                comando.Parameters.AddWithValue("@Pass", Pass);
                comando.Parameters.AddWithValue("ipMaquina", IP);
                res = comando.Parameters.AddWithValue("@Resultado","");
                comando.Parameters["@Resultado"].Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();


                return res.Value.ToString();
               // Console.WriteLine(res.Value.ToString()+ "La vaca");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3";
            }
           
        }
        public void CerrarSesion(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPCerrarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
           
        }
        public void MantenerSesion(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPMantenerSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public string LoginL(string IP)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SPSesion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IpMaquina", IP);
                res = comando.Parameters.AddWithValue("@Resultado", " ");
                comando.Parameters["@Resultado"].Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();


                return res.Value.ToString();
                // Console.WriteLine(res.Value.ToString()+ "La vaca");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR";
            }

        }
    }
}
