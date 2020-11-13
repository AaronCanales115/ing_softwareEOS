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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        DmConsultas c = new DmConsultas();
        DmProveedor pr = new DmProveedor();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            llenarCBX();
            VerProveedores();
        }
        private void llenarCBX()
        {
            cbxTipo.DataSource = c.ConsultaTab("SELECT tipoProveedor.idTipoProveedor,tipoProveedor.Descripcion FROM tipoProveedor;");
            cbxTipo.DisplayMember = "Descripcion";
            cbxTipo.ValueMember = "idTipoProveedor";
        }
        private void VerProveedores()
        {
            pr.VerProveedores(dgvVer);
            dgvVer.Columns[0].Visible = false;
        }

        private void dgvVer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            if (dgvVer.SelectedRows.Count > 0)
            {
                string idProveedor = dgvVer.CurrentRow.Cells["ID"].Value.ToString();
                lblId.Text = idProveedor;
                txtNombre.Text = dgvVer.CurrentRow.Cells["Nombre"].Value.ToString();
                txtUbicacion.Text = dgvVer.CurrentRow.Cells["Ubicación"].Value.ToString();
                txtIdent.Text = dgvVer.CurrentRow.Cells["Identificación"].Value.ToString();
                cbxTipo.Text = dgvVer.CurrentRow.Cells["Tipo"].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)//Boton modificar
        {
            if (ValidarVacios())
            {
                string id = lblId.Text;
                string nombre = txtNombre.Text;
                string identificacion = txtIdent.Text;
                string ubicacion = txtUbicacion.Text;
                pr.ModProveedor(id,nombre,identificacion,ubicacion);
                limpiar();
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = false;
                MessageBox.Show("Proveedor Modificado", "MODIFICAR", MessageBoxButtons.OK,MessageBoxIcon.Information);
                VerProveedores();
            }
        }
        private bool ValidarVacios()
        {
            if(txtNombre.Text.Trim() == "" || txtIdent.Text.Trim() == "" || txtUbicacion.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                string nombre = txtNombre.Text;
                string identificacion = txtIdent.Text;
                string ubicacion = txtUbicacion.Text;
                string tipo = cbxTipo.SelectedValue.ToString();
                pr.AddProveedor(nombre,identificacion,ubicacion,tipo);
                MessageBox.Show("Proveedor Guardado", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                VerProveedores();
            }
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtIdent.Text = "";
            txtUbicacion.Text = "";
            lblId.Text = "";
            cbxTipo.SelectedIndex = 0;
        }

        private void dgvVer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idProveedor = dgvVer.CurrentRow.Cells["ID"].Value.ToString();
            Console.WriteLine(idProveedor);
            pr.EliminarProveedor(idProveedor);
            MessageBox.Show("Proveedor Eliminado", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            VerProveedores();
        }
    }
}
