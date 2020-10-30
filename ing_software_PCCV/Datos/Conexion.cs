using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        //string cadena = "Data Source = VARGASFLORES; Initial Catalog = dbStore; Integrated Security = True";
        public SqlConnection conexion = new SqlConnection("Data Source = AARONPC; Initial Catalog = dbStore; Integrated Security = True");

        //public Conexion()
        //{
        //    conectarbd.ConnectionString = cadena;
        //}

        //public void abrir()
        //{
        //    try
        //    {
        //        conectarbd.Open();
        //        Console.WriteLine("Conexion exitosa");
        //    }catch(Exception ex)
        //    {
        //        Console.WriteLine("Error en la conexion " + ex);
        //    }
        //}
        //public void cerrar()
        //{
        //    conectarbd.Close();
        //}

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        /*
        SELECT idProducto as ID
       ,Producto.Nombre
	   ,Producto.Descripcion
	   ,Producto.Precio
	   ,Producto.Stock
	   ,Producto.Talla
        FROM Producto; 
        
        
        */
    }
}
