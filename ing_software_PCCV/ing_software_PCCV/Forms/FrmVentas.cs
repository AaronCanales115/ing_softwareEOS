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
        ArrayList arr2 = new ArrayList();

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            mostrar("1");
        }
        private void mostrar(string valor)
        {
            ODm.MostrarProductos(dgvMostrar, valor);
            dgvMostrar.Columns["Descripcion"].Visible = false;
            
        }//mostrar los productos en el datagrid

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)//Busca en la base de datos
        {
            int valor = Convert.ToInt16(lblValor.Text.Trim());
            Buscar b = new Buscar();
            b.Filtrar(dgvMostrar, this.txtBuscar.Text.Trim(), valor);
            dgvMostrar.Columns["PCompra"].Visible = false;
        }
        private void DataGrid()//Agrega los valores de la tabla a las variables
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
        private void agregar(string id, string Nombre, decimal Precio, int existencia)//agrega los productos a la tabla lista
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
        private bool validarNombre(string nombre)//validar si el nombre esta repetido
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

        private void dgvLista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvLista.CurrentRow.Cells["Cantidad"].Value == null || String.IsNullOrEmpty(dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString()))
            {
                MessageBox.Show("Ingrese la cantidad de productos", "Error,Cantidad vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal ab = 0;
                string precio = dgvLista.CurrentRow.Cells["Precio"].Value.ToString();
                string cant = dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString();
                string ex = dgvLista.CurrentRow.Cells["Existencias"].Value.ToString();
                decimal pr = Convert.ToDecimal(precio);
                int ca = Convert.ToInt32(cant);
                int exi = Convert.ToInt32(ex);
                if (ca > exi)
                {
                    MessageBox.Show("Error, La cantidad a vender no puede ser mayor que la existencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ca == 0)
                    {
                        MessageBox.Show("Error, La cantidad no puede ser 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // dgvLista.CurrentRow.Cells["Cantidad"].Value = 0;
                    }
                    else
                    {
                        decimal a = pr * ca;

                        decimal val = Convert.ToDecimal(txtSubTotal.Text.Trim());
                        if (val <= 0)
                        {
                            txtSubTotal.Text = a + "";
                            lblTotal.Text = a + "";
                        }
                        else
                        {
                            ab = a + val;
                            txtSubTotal.Text = ab + "";
                            lblTotal.Text = ab + "";
                        }
                        arr2.Add(a);
                    }
                }



            }
        }
    }
}
