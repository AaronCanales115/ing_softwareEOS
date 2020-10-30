using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    class Conexion
    {
        string cadena = "Data Source = VARGASFLORES; Initial Catalog = dbStore; Integrated Security = True";
        public SqlConnection conectarbd = new SqlConnection();

        public Conexion()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion exitosa");
            }catch(Exception ex)
            {
                Console.WriteLine("Error en la conexion " + ex);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
