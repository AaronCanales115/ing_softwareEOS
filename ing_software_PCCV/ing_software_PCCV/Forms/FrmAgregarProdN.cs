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
    public partial class FrmAgregarProdN : Form
    {
        public FrmAgregarProdN()
        {
            InitializeComponent();
        }
        private DmProductos ODm = new DmProductos();
        private DmObtenerIP IP = new DmObtenerIP();
        private DmConsultas c = new DmConsultas();


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreV.Text;
            string descripcion = txtDescripcionV.Text;
            string precio = txtPrecioV.Text;
            string cantidad = txtCantidadV.Text;
            string proveedor = cbxProveedor.SelectedValue.ToString();
            string estado = cbxEstado.SelectedText.ToString();
            string talla = txtTalla.Text;
            string usuario = lblidUsuario.Text;
            string resultado = "1";
            string categoria = "1";
            string NFactura = "fac";
            string total = "";

            ODm.agregarProductoNuevo(usuario, nombre, descripcion, precio, talla, categoria, estado, NFactura, cantidad, total, proveedor, resultado);

            MessageBox.Show("Producto guardado");

        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmAgregarProdN_Load(object sender, EventArgs e)
        {
            string IMP = IP.ObtenerMac();
            string ip = c.ConsultaSimple("SELECT IpMaquina.idUsuario FROM IpMaquina WHERE ipMaquina ='" + IMP.Trim() + "'");
            lblidUsuario.Text = ip;

            llenarcbx();
        }

        public void llenarcbx()
        {
            //cbxProveedor.DataSource = c.Consulta("SELECT RazonSocial, idProveedor FROM Proveedor;");
            //cbxProveedor.DisplayMember = "RazonSocial";
            //cbxProveedor.ValueMember = "idProveedor";
        }

        public void mostrarVistaPreliminar()
        {

        }

        private void rbtnVestimenta_CheckedChanged(object sender, EventArgs e)
        {
            gbVestimenta.Visible = true;
            gbBisuteria.Visible = false;
            gbCalzado.Visible = false;
        }

        private void rbtnCalzado_CheckedChanged(object sender, EventArgs e)
        {
            gbVestimenta.Visible = false;
            gbBisuteria.Visible = false;
            gbCalzado.Visible = true;
        }

        private void rbtnBisuteria_CheckedChanged(object sender, EventArgs e)
        {
            gbVestimenta.Visible = false;
            gbBisuteria.Visible = true;
            gbCalzado.Visible = false;
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreC.Text;
            string descripcion = txtDescripcionC.Text;
            string precio = txtPrecioC.Text;
            string cantidad = txtCantidadC.Text;
            string proveedor = cbxProveedorC.SelectedValue.ToString();
            string estado = cbxEstadoC.SelectedText.ToString();
            string talla = txtTallaC.Text;
            string usuario = lblidUsuario.Text;
            string resultado = "1";
            string categoria = "1";
            string NFactura = "fac";
            string total = "";

            ODm.agregarProductoNuevo(usuario, nombre, descripcion, precio, talla, categoria, estado, NFactura, cantidad, total, proveedor, resultado);

            MessageBox.Show("Producto guardado");
        }

        private void btnGuardarB_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreB.Text;
            string descripcion = txtDescripcionB.Text;
            string precio = txtPrecioB.Text;
            string cantidad = txtCantidadB.Text;
            string proveedor = cbxProveedorB.SelectedValue.ToString();
            string estado = cbxEstadoB.SelectedText.ToString();
            string talla = "";
            string usuario = lblidUsuario.Text;
            string resultado = "1";
            string categoria = "1";
            string NFactura = "fac";
            string total = "";

            ODm.agregarProductoNuevo(usuario, nombre, descripcion, precio, talla, categoria, estado, NFactura, cantidad, total, proveedor, resultado);

            MessageBox.Show("Producto guardado");
        }
    }
}
