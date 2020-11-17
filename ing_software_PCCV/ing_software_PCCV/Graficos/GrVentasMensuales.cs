using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using System.Collections;
namespace ing_software_PCCV.Graficos
{
    public partial class GrVentasMensuales : Form
    {
        public GrVentasMensuales()
        {
            InitializeComponent();
        }
        DmGraficos dmg = new DmGraficos();
        DmConsultas ct = new DmConsultas();
        DataTable dt = new DataTable();
        ArrayList A1 = new ArrayList();
        ArrayList A2 = new ArrayList();
        private void GrVentasMensuales_Load(object sender, EventArgs e)
        {
            
            dmg.VerVentasMes();
            dt = ct.ConsultaTab("SELECT MesesM.Meses,MesesM.Monto FROM MesesM");
            string result1,result2;
          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result1 = Convert.ToString(dt.Rows[i][0]);
                result2 = Convert.ToString(dt.Rows[i][1]);
                A1.Add(result1);
                A2.Add(result2);
                Console.WriteLine(result1+  " " + result2);
            }
            chtGrafico.Series[0].Points.DataBindXY(A1,A2);



        }
    }
}
