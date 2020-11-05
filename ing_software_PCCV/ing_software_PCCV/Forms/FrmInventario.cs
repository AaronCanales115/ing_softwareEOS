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
    public partial class FrmInventario : Form
    {
       
       
        public FrmInventario()
        {
            InitializeComponent();
        }
        DmConsultas c = new DmConsultas();
        private DmProductos ODm = new DmProductos();
        DmObtenerIP IP = new DmObtenerIP();
        string idProducto;
        FrmPrincipal p = new FrmPrincipal();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarProductos(string valor)
        {
            
            ODm.MostrarProductos(dgvMostrar,valor);
            
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            string IPM = IP.ObtenerMac();
            string ip = c.ConsultaSimple("SELECT IpMaquina.idUsuario FROM IpMaquina WHERE ipMaquina ='" + IPM.Trim() + "'");
             lblUs.Text = ip;
            mostrarProductos("1");
           
        }

        
        private void dgvMostrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                idProducto = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
                txtNombre.Text = dgvMostrar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvMostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvMostrar.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dgvMostrar.CurrentRow.Cells["Cantidad"].Value.ToString();
                if(lblValor.Text.Trim() == "1")
                {
                    txtTalla.Text = dgvMostrar.CurrentRow.Cells["Talla"].Value.ToString();
                }
                else
                {
                    if(lblValor.Text.Trim() == "5")
                    {
                        txtTalla.Text = dgvMostrar.CurrentRow.Cells["Tamaño"].Value.ToString();
                    }
                    else
                    {
                        if (lblValor.Text.Trim() == "9")
                        {
                            txtTalla.Text = dgvMostrar.CurrentRow.Cells["Medida"].Value.ToString();
                        }
                    }
                }
               

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16( lblValor.Text.Trim());
            Buscar b = new Buscar();
            b.Filtrar(dgvMostrar, this.txtBuscar.Text.Trim(),valor);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click_2(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string talla = txtTalla.Text;
            string usuario = lblUs.Text.Trim();
            string estado = "1";
            ODm.Editar(idProducto, nombre, descripcion, precio, stock, talla,estado, usuario);
            mostrarProductos(lblValor.Text.Trim());
            MessageBox.Show("Producto modificado","Modificar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string usuario = lblUs.Text.Trim();
            string resultado = "1";
            string id = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
            ODm.eliminar(id, usuario, resultado);
            MessageBox.Show("Producto eliminado","Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrarProductos(lblValor.Text.Trim());
            
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            Buscar b = new Buscar();
            int valor = Convert.ToInt32(lblValor.Text.Trim());
            b.Filtrar(dgvMostrar,this.txtBuscar.Text.Trim(), valor);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblValor.Text = "1";
            txtBuscar.Text = "";
            mostrarProductos("1");
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lblValor.Text = "5";
            txtBuscar.Text = "";
            mostrarProductos("5");

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            lblValor.Text = "9";
            txtBuscar.Text = "";
            mostrarProductos("9");

        }
        public void label(string v)
        {
            lblUs.Text = v;
        }
    }
}
