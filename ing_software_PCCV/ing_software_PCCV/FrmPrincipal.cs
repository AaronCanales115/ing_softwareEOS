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

namespace ing_software_PCCV
{
    public partial class FrmPrincipal : Form
    {
        DmLogin Lg = new DmLogin();
        DmConsultas con = new DmConsultas();
        
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
            string dato = lbldato2.Text.Trim();

             if(dato == "NO")
              {
                  Lg.CerrarSesion(lbldato.Text.Trim());
              }
              if(dato == "OK")
              {
                  Lg.MantenerSesion(lbldato.Text.Trim());
              }
           
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string v, v2, v3;
            ArrayList arr = new ArrayList();
            string valor = lbldato.Text.Trim();
         arr =   con.Consulta("SELECT Nombre, Apellido,Rol.Descripcion FROM Usuario,Rol WHERE Usuario.tipo = Rol.idRol AND idUsuario ='"+valor+"'");

            v = arr[0].ToString();
            v2 = arr[1].ToString();
            v3 = arr[2].ToString();
            lblUser.Text = v + " " + v2 + " - " + v3;
            //lblUser.Text = v;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Lg.CerrarSesion(lbldato.Text.Trim());
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void existenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
