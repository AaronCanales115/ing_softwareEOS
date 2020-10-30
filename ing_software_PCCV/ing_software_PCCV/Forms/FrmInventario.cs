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

        private DmProductos ODm = new DmProductos();
        string idProducto;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar";
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string talla = txtTalla.Text;
            string categoria = "1";
            string usuario = "1";
            string estado = "1";
            string resultado = "da";
            ODm.Editar(idProducto, nombre, descripcion, precio, stock, talla, categoria, estado, usuario, resultado);
            mostrarProductos();
            MessageBox.Show("Funciona");
        }

        private void mostrarProductos()
        {
            dgvMostrar.DataSource = ODm.MostrarProductos();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            mostrarProductos();
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
                txtStock.Text = dgvMostrar.CurrentRow.Cells["Stock"].Value.ToString();
                txtTalla.Text = dgvMostrar.CurrentRow.Cells["Talla"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar b = new Buscar();
            b.Filtrar(dgvMostrar, this.txtBuscar.Text.Trim());
        }
    }
}
