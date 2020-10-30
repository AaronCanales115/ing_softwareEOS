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

namespace ing_software_PCCV
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private Form formActivo = null;

        private void abrirForm(Form NuevoForm)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = NuevoForm;
            NuevoForm.TopLevel = false;
            NuevoForm.FormBorderStyle = FormBorderStyle.None;
            NuevoForm.Dock = DockStyle.Fill;
            pContenedor.Controls.Add(NuevoForm);
            pContenedor.Tag = NuevoForm;
            NuevoForm.BringToFront();
            NuevoForm.Show();


        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmInventario());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
