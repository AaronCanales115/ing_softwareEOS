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
    public partial class FrmAgregarProdE : Form
    {
        public FrmAgregarProdE()
        {
            InitializeComponent();
        }
        private DmProductos ODm = new DmProductos();


        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
            }
        }

        private void mostrarProductos(string valor)
        {

            ODm.MostrarProductos(dgvMostrar, valor);

        }

        private void FrmAgregarProdE_Load(object sender, EventArgs e)
        {
            mostrarProductos("1");
        }
    }
}
