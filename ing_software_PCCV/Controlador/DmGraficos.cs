using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Datos;
using System.Data;
namespace Controlador
{
   public class DmGraficos
    {
        DtGraficos dtg = new DtGraficos();
        public void VerVentasMes()
        {
            dtg.VerVentasMes(); ;
        }
        public DataTable Categorias()
        {
            DataTable DT = new DataTable();
            DT = dtg.VerCategorias();
            return DT;
        }
    }
}
