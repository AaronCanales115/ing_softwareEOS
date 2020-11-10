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
        ArrayList Cat = new ArrayList();



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreV.Text;
            string descripcion = txtDescripcionV.Text;
            string precio = txtPrecioV.Text;
            string cantidad = txtCantidadV.Text;
            string talla = txtTalla.Text;
            bool nom = validarNombre(nombre);
            if (nom)
            {
                agregar(nombre, precio, cantidad, talla, descripcion);
            }
            else
            {
                MessageBox.Show("Ya ingresó un producto con el mismo nombre","Error, Producto repetido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           


          //  MessageBox.Show("Producto guardado");

        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void FrmAgregarProdN_Load(object sender, EventArgs e)
        {
            string ip = c.obtenerID();
            lblidUsuario.Text = ip;
            Cat.Clear();
            llenarcbx();
        }

        public void llenarcbx()
        {
            cbxProveedor.DataSource = c.ConsultaTab("SELECT RazonSocial, idProveedor FROM Proveedor;");
            cbxProveedor.DisplayMember = "RazonSocial";
            cbxProveedor.ValueMember = "idProveedor";

        }

        public void mostrarVistaPreliminar()
        {

        }

        private void rbtnVestimenta_CheckedChanged(object sender, EventArgs e)
        {
           if(rbtnVestimenta.Checked == true)
            {
                lblCategoria.Text = "1";
                lblTalla.Text = "Talla";
            }
          
        }

        private void rbtnCalzado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCalzado.Checked == true)
            {
                lblCategoria.Text = "5";
                lblTalla.Text = "Tamaño";
            }
        }

        private void rbtnBisuteria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBisuteria.Checked == true)
            {
                lblCategoria.Text = "9";
                lblTalla.Text = "Unidades";
            }
        }

        private bool validarNombre(string nombre)
        {
            string name;
            int a = dgvLista.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                name = dgvLista.Rows[i].Cells[0].Value.ToString();
                if (name.Trim().Equals(nombre.Trim()))
                {

                    i = a;
                    return false;
                }
            }
            return true;
        }//valoda que no se ingrese un producto repetido


        private void SoloNumeros(KeyPressEventArgs e)
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

        private void txtNFacturaV_TextChanged(object sender, EventArgs e)
        {

        }
        private void agregar( string nombre, string precio, string cant,string medida, string desc)//agrega los productos al dgv
        {
            double valor = 0, ab =0;
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvLista);
            fila.Cells[0].Value = nombre;
            fila.Cells[1].Value = precio;
            fila.Cells[2].Value = medida;
            fila.Cells[3].Value = cant;
            fila.Cells[4].Value = desc;

            dgvLista.Rows.Add(fila);
            string val = lblCategoria.Text.Trim();
            Cat.Add(val);
            txtCantTot.Text = Convert.ToString(dgvLista.RowCount);
            if(cant != "")
            {
                int ca = Convert.ToInt32(cant.Trim());
                if(ca >= 0)
                {
                    double pre = Convert.ToDouble(precio);
                    double a = pre * ca;

                    valor = Convert.ToDouble(lblTotal.Text.Trim());
                    if (valor <= 0)
                    {
                       
                        lblTotal.Text = a + "";
                    }
                    else
                    {
                        ab = a + valor;
                       
                        lblTotal.Text = ab + "";
                    }
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
           
            int a = dgvLista.Rows.Count;
            string nf = txtFactura.Text;
            if (nf.Trim() == "")
            {
                MessageBox.Show("Error, Ingrese un número de factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < a; i++)
                {
                    string us = c.obtenerID();
                    string pro = cbxProveedor.SelectedValue.ToString();
                    string nom = dgvLista.Rows[i].Cells[0].Value.ToString();
                    string prec = dgvLista.Rows[i].Cells[1].Value.ToString();
                    string med = dgvLista.Rows[i].Cells[2].Value.ToString();
                    string canti = dgvLista.Rows[i].Cells[3].Value.ToString();
                    string decr = dgvLista.Rows[i].Cells[4].Value.ToString();
                    string estado = "1";
                    string fac = txtFactura.Text;
                    string cat = Cat[i].ToString();
                   string cf=  ODm.agregarProductoNuevo(us,nom,decr,prec,med,cat,estado,fac,canti,pro);
                    Console.WriteLine(cf);
                }

                MessageBox.Show("Compra realizada con exito", "COMPRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                //MessageBox.Show("Uno de los campos en la lista de compras esta vacio", "ERROR, CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }   
        }

        private void chxFactura_CheckedChanged(object sender, EventArgs e)
        {
            if(chxFactura.Checked == true)
            {
                txtFactura.Text = "SIN FACTURA";
                txtFactura.Enabled = false;
            }
            if (chxFactura.Checked == false)
            {
               
                txtFactura.Enabled = true;
            }

        }
    }
}
