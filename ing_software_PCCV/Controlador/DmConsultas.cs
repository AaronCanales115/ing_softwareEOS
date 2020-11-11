using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Collections;
using System.Data;

namespace Controlador
{
    public class DmConsultas
    {
        DtConsultas c = new DtConsultas();
        ArrayList arr = new ArrayList();
        DataTable dt = new DataTable();
        DmObtenerIP IP = new DmObtenerIP();
       
        public string ConsultaSimple(string sql)
        {
           string resultado =  c.CSimple(sql);
            return resultado;
        }
        public ArrayList Consulta(string sql)
        {
            string result;
            dt = c.Consulta(sql);
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                result = Convert.ToString(dt.Rows[0][i]);
                arr.Add(result);
            }
            return arr;
        }
        public DataTable ConsultaTab (string sql)
        {
            DataTable tab = new DataTable();
            tab = c.Consulta(sql);
            return tab;
        }
        public void Insertar(string sql)
        {
            c.Insertar(sql);
        }
        public string obtenerID()
        {
            string IPM = IP.ObtenerMac();
            string ip = ConsultaSimple("SELECT IpMaquina.idUsuario FROM IpMaquina WHERE ipMaquina ='" + IPM.Trim() + "'");

            return ip;
        }
    }
}
