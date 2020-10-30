using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Controlador
{
    public class DConexion
    {
        public string conectar()
        {
            Conexion con = new Conexion();
            string val = con.abrir();
            return val;
        }
    }
}
