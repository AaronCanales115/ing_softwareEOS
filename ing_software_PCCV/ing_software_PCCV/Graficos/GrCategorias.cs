using Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ing_software_PCCV.Graficos
{
    public partial class GrCategorias : Form
    {
        public GrCategorias()
        {
            InitializeComponent();
        }
        DmGraficos dmg = new DmGraficos();
        DataTable dt = new DataTable();
        ArrayList A1 = new ArrayList();
        ArrayList A2 = new ArrayList();
        ArrayList A3 = new ArrayList();

        private void GrCategorias_Load(object sender, EventArgs e)
        {

          dt =  dmg.Categorias();
          
            string result1, result2,result3;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result1 = Convert.ToString(dt.Rows[i][0]);
                result2 = Convert.ToString(dt.Rows[i][1]);
                result3 = Convert.ToString(dt.Rows[i][2]);
                A1.Add(result1);
                A2.Add(result2);
                A3.Add(result3);
              // Console.WriteLine(result1 + " " + result2+ "  "+result3);
            }
            chValor.Series[0].Points.DataBindXY(A1, A3);
            chCantidad.Series[0].Points.DataBindXY(A1, A2);
        }
    }
}
