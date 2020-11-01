using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Controlador
{
    public class DmConsultas
    {
        DtConsultas c = new DtConsultas();
        public string ConsultaSimple(string sql)
        {
           string resultado =  c.CSimple(sql);
            return resultado;
        }
    }
}
