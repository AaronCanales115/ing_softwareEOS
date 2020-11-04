﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Datos
{
    public class DtProductos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void mostrarProductos(DataGridView data, int Numero)
        {
            
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("SPMostrarProductos", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Valor", Numero);
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            data.DataSource = tab;
            
           
        }
      

        public void Editar(int id, string nombre, string descripcion, decimal precio, int stock, string talla, int categoria, int estado, int usuario, string resultado)
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
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Resultado", resultado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id, int usuario, string resultado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPEliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", id);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Resultado", resultado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
