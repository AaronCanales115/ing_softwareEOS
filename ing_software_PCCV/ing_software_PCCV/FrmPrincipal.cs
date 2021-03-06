﻿using System;
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
using DevExpress.XtraReports.UI;

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
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            string v, v2, v3;
            ArrayList arr = new ArrayList();
            Frame();
            string valor = lbldato.Text.Trim();
         arr =   con.Consulta("SELECT Nombre, Apellido,Rol.Descripcion FROM Usuario,Rol WHERE Usuario.tipo = Rol.idRol AND idUsuario ='"+valor+"'");

            v = arr[0].ToString();
            v2 = arr[1].ToString();
            v3 = arr[2].ToString();
            lblUser.Text = v + " " + v2 + " - " + v3;
            if(v3.Trim().ToUpper() == "VENDEDOR")
            {
                compraDeProductosToolStripMenuItem.Enabled = false;
            }
            //lblUser.Text = v;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Frame()
        {
            Forms.FrmAbrirCaja ac = new Forms.FrmAbrirCaja();
          
            string cons = con.ConsultaSimple("SELECT Cuentas.Puerta FROM Cuentas WHERE Cuentas.idCuentas = 1;");
            int dato = Convert.ToInt32(cons);
            if(dato == 1)
            {
                ac.ShowDialog();
            }
          
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Lg.CerrarSesion(lbldato.Text.Trim());
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmAgregarProdN());
        }

        private void existenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmAgregarProdE());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmVentas());
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmProveedores prove = new Forms.FrmProveedores();
            prove.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancelarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmCancelarFacturaV ver = new Forms.frmCancelarFacturaV();
            ver.ShowDialog();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmCerrarCaja cc = new Forms.FrmCerrarCaja();
            cc.ShowDialog();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.RptLibroDiario rp = new Reportes.RptLibroDiario();
            rp.ShowPreview();
        }

        private void agregarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmAgregarGastos ag = new Forms.FrmAgregarGastos();
            ag.ShowDialog();
        }

        private void ventasPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Graficos.GrVentasMensuales());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Graficos.GrCategorias());
        }
    }
}
