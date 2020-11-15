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
    public partial class FrmAbrirCaja : Form
    {
        public FrmAbrirCaja()
        {
            InitializeComponent();
        }
        DmVentas v = new DmVentas();

        private void button1_Click(object sender, EventArgs e)
        {
            v.abrirCaja(txtMonto.Text.Trim());
            MessageBox.Show("Monto Guardado", "Abrir Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
