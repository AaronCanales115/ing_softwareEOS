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
            string idProveedor = cbxProveedor.SelectedValue.ToString();
            string estado = cbxEstado.SelectedText.ToString();
            string talla = txtTalla.Text;
            string usuario = lblidUsuario.Text;
            string categoria = "1";
            string NFactura = txtNFacturaV.Text;
            string total = "";

            string nombreProductoEx =  c.ConsultaSimple("SELECT Nombre FROM Producto WHERE Nombre = "+ txtNombreV +"");

            ODm.agregarProductoNuevo(usuario, nombre, descripcion, precio, talla, categoria, estado, NFactura, cantidad, total, idProveedor);
            detallesCompra();
            limpiar();
            MessageBox.Show("Producto guardado");

        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumero(e);
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumero(e);
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
            cbxProveedor.DataSource = c.ConsultaTab("SELECT idProveedor, RazonSocial FROM Proveedor;");
            cbxProveedor.DisplayMember = "RazonSocial";
            cbxProveedor.ValueMember = "idProveedor";

            cbxProveedorC.DataSource = c.ConsultaTab("SELECT idProveedor, RazonSocial FROM Proveedor;");
            cbxProveedorC.DisplayMember = "RazonSocial";
            cbxProveedorC.ValueMember = "idProveedor";

            cbxProveedorB.DataSource = c.ConsultaTab("SELECT idProveedor, RazonSocial FROM Proveedor;");
            cbxProveedorB.DisplayMember = "RazonSocial";
            cbxProveedorB.ValueMember = "idProveedor";
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
            string nombreC = txtNombreC.Text;
            string descripcionC = txtDescripcionC.Text;
            string precioC = txtPrecioC.Text;
            string cantidadC = txtCantidadC.Text;
            string proveedorC = cbxProveedorC.SelectedValue.ToString();
            string estadoC = cbxEstadoC.SelectedText.ToString();
            string tallaC = txtTallaC.Text;
            string usuario = lblidUsuario.Text;
            string categoria = "5";
            string NFactura = txtNFacturaC.Text;
            string total = "";

            ODm.agregarProductoNuevo(usuario, nombreC, descripcionC, precioC, tallaC, categoria, estadoC, NFactura, cantidadC, total, proveedorC);
            limpiar();
            MessageBox.Show("Producto guardado");
        }

        private void btnGuardarB_Click(object sender, EventArgs e)
        {
            string nombreB = txtNombreB.Text;
            string descripcionB = txtDescripcionB.Text;
            string precioB = txtPrecioB.Text;
            string cantidadB = txtCantidadB.Text;
            string proveedorB = cbxProveedorB.SelectedValue.ToString();
            string estadoB = cbxEstadoB.SelectedText.ToString();
            string talla = "";
            string usuario = lblidUsuario.Text;
            string categoria = "1";
            string NFactura = txtNFacturaB.Text;
            string total = "";

            ODm.agregarProductoNuevo(usuario, nombreB, descripcionB, precioB, talla, categoria, estadoB, NFactura, cantidadB, total, proveedorB);
            limpiar();
            MessageBox.Show("Producto guardado");
        }

        public void detallesCompra()
        {
            if (rbtnVestimenta.Checked == true)
            {
                int piezas = Convert.ToInt32(txtCantidadV.Text);
                double precio = Convert.ToDouble(txtPrecioV.Text);
                double subTotal = precio * piezas;

                txtNPiezas.Text = piezas.ToString();
                txtSubTotal.Text = subTotal.ToString();
                lblTotal.Text = "C$ " + subTotal.ToString();

            }

            if (rbtnCalzado.Checked == true)
            {
                int piezas = Convert.ToInt32(txtCantidadC.Text);
                double precio = Convert.ToDouble(txtPrecioC.Text);
                double subTotal = precio * piezas;

                txtNPiezas.Text = piezas.ToString();
                txtSubTotal.Text = subTotal.ToString();
                lblTotal.Text = "C$ " + subTotal.ToString();

            }

            if (rbtnBisuteria.Checked == true)
            {
                int piezas = Convert.ToInt32(txtCantidadB.Text);
                double precio = Convert.ToDouble(txtPrecioB.Text);
                double subTotal = precio * piezas;

                txtNPiezas.Text = piezas.ToString();
                txtSubTotal.Text = subTotal.ToString();
                lblTotal.Text = "C$ " + subTotal.ToString();

            }

        }

        public void limpiar()
        {
            //vestimenta
            txtNombreV.Clear();
            txtDescripcionV.Clear();
            txtPrecioV.Clear();
            txtCantidadV.Clear();
            cbxProveedor.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            txtTalla.Clear();
            txtNFacturaV.Clear();

            //bisuteria
            txtNombreB.Clear();
            txtDescripcionB.Clear();
            txtPrecioB.Clear();
            txtCantidadB.Clear();
            cbxProveedorB.SelectedIndex = 0;
            cbxEstadoB.SelectedIndex = 0;
            txtNFacturaB.Clear();

            //Calzado
            txtNombreC.Clear();
            txtDescripcionC.Clear();
            txtPrecioC.Clear();
            txtCantidadC.Clear();
            cbxProveedorC.SelectedIndex = 0;
            cbxEstadoC.SelectedIndex = 0;
            txtTallaC.Clear();
            txtNFacturaC.Clear();
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
