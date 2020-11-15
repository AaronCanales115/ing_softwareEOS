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
    public partial class FrmAgregarGastos : Form
    {
        public FrmAgregarGastos()
        {
            InitializeComponent();
        }
        DmVentas v = new DmVentas();
        private void FrmAgregarGastos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            v.AgregarGasto(txtMonto.Text.Trim(), txtDesc.Text);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumero(e);
        }
        private void ValidarSoloNumero(KeyPressEventArgs e)
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
