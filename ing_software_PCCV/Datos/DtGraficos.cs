using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DtGraficos
    {
        private Conexion conexion = new Conexion();
   
        public void VerVentasMes()
        {
            
            SqlCommand sql = new SqlCommand("SPMeses", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.ExecuteNonQuery();
    }
        public DataTable VerCategorias()
        {
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("SPVerCategoriaVentas", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            return tab;
        }

    }
}
