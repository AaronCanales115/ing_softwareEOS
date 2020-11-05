﻿using System;
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
        
      //public SqlConnection conexion = new SqlConnection("Data Source = AARONPC; Initial Catalog = dbStore; Integrated Security = True");
       public SqlConnection conexion = new SqlConnection("Data Source = VARGASFLORES; Initial Catalog = dbStore; Integrated Security = True");

        

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

        
        
        
       
    }
}
