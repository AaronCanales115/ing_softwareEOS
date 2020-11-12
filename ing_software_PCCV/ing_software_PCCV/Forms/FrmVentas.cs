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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        private DmProductos ODm = new DmProductos();
        ArrayList arr1 = new ArrayList();

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            mostrar("1");
        }
        private void mostrar(string valor)
        {
            ODm.MostrarProductos(dgvMostrar, valor);
            dgvMostrar.Columns["Descripcion"].Visible = false;
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblValor.Text = "1";
            txtBuscar.Text = "";
            mostrar("1");
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lblValor.Text = "5";
            txtBuscar.Text = "";
            mostrar("5");
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            lblValor.Text = "9";
            txtBuscar.Text = "";
            mostrar("9");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16(lblValor.Text.Trim());
            Buscar b = new Buscar();
            b.Filtrar(dgvMostrar, this.txtBuscar.Text.Trim(), valor);
            dgvMostrar.Columns["PCompra"].Visible = false;
        }
        private void DataGrid()
        {
            string talla;
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                string id = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
                string nombre = dgvMostrar.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion = dgvMostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
                string precio = dgvMostrar.CurrentRow.Cells["PVenta"].Value.ToString();
                string cantidad = dgvMostrar.CurrentRow.Cells["Cantidad"].Value.ToString();
                if (lblValor.Text.Trim() == "1")
                {
                    talla = dgvMostrar.CurrentRow.Cells["Talla"].Value.ToString();
                }
                else
                {
                    if (lblValor.Text.Trim() == "5")
                    {
                        talla = dgvMostrar.CurrentRow.Cells["Tamaño"].Value.ToString();
                    }
                    else
                    {
                        if (lblValor.Text.Trim() == "9")
                        {
                            talla = dgvMostrar.CurrentRow.Cells["Medida"].Value.ToString();
                        }
                    }
                }

                bool va = validarNombre(nombre);
                if (va)
                {
                    agregar(id, nombre, Convert.ToDecimal(precio.Trim()), Convert.ToInt32(cantidad));
                }
                else
                {
                    MessageBox.Show("Error, El producto ya esta en la lista de compra", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }
        private void agregar(string id, string Nombre, decimal Precio, int existencia)
        {

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvLista);
            fila.Cells[0].Value = Nombre;
            fila.Cells[1].Value = Precio;
            fila.Cells[2].Value = existencia;

            dgvLista.Rows.Add(fila);
            txtNPiezas.Text = Convert.ToString(dgvLista.Rows.Count);
            arr1.Add(id);


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
        }

        private void dgvMostrar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGrid();
        }
        private void dText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvLista_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }
    }
}
