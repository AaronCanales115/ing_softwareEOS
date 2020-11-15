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
namespace ing_software_PCCV.Forms
{
    public partial class FrmCerrarCaja : Form
    {
        public FrmCerrarCaja()
        {
            InitializeComponent();
        }
        DmVentas v = new DmVentas();

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void FrmCerrarCaja_Load(object sender, EventArgs e)
        {
            
            lblTotal.Text = v.MontoFinal();
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            v.Cerrar();
            MessageBox.Show("Caja cerrada con éxito","Cerrar Caja",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
