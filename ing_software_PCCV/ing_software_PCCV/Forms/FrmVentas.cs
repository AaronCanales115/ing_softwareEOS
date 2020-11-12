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
        DmVentas v = new DmVentas();
        ArrayList arr1 = new ArrayList();
        DmConsultas c = new DmConsultas();
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
                  
                    //arr2.Add()
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
               
                string cant = dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString();
                string ex = dgvLista.CurrentRow.Cells["Existencias"].Value.ToString();
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
                  
                    }
                



            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string cantidad;
            int a = dgvLista.Rows.Count;
            string nf = txtFactura.Text;
            if (nf.Trim() == "")
            {
                MessageBox.Show("Error, Ingrese un número de factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "")
                {
                    MessageBox.Show("Error, uno de los datos del cliente está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ValidarVacio() == false)
                    {
                        string usuario = c.obtenerID();
                        string nombre = txtNombre.Text;
                        string apellido = txtApellido.Text;
                        string canti = txtNPiezas.Text;
                        string desc = txtDescuento.Text;
                        string subt = txtSubTotal.Text;
                        string total1 = lblTotal.Text;
                        string res = v.agregarVenta(nf, usuario, nombre, apellido, canti, desc, subt, total1);
                        string res2 = c.ConsultaSimple("SELECT MAX(Venta.idVenta) FROM Venta");
                        lblIdVenta.Text = res2;
                        Console.WriteLine(res2);
                        if (res != "NO")
                        {
                            for (int i = 0; i < a; i++)
                            {
                                cantidad = dgvLista.Rows[i].Cells[3].Value.ToString();
                                string idv = lblIdVenta.Text;
                                string id = arr1[i].ToString();
                                v.ventaProducto(id, idv, cantidad);


                                //Aqui guarda


                            }

                            MessageBox.Show("Venta realizada con exito", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrar("1");
                            LimpiarDGV();
                        }
                        else
                        {
                            MessageBox.Show("Error en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                   
                    else
                    {
                        MessageBox.Show("Uno de los campos en la lista de compras esta vacio", "ERROR, CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private bool ValidarVacio()
        {
            bool bCampoVacio = false;
            if (dgvLista.RowCount > 0)
            {

                foreach (DataGridViewRow dr in dgvLista.Rows)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
                        {
                            bCampoVacio = true;
                        }
                    }
                }
                return bCampoVacio;
            }

            return bCampoVacio;
        }
        private void LimpiarDGV()
        {
            dgvLista.Rows.Clear();
            dgvLista.Refresh();
            txtNPiezas.Text = "";
            txtSubTotal.Text = "";
            lblTotal.Text = "";
           
            //dgvLista.Columns.Clear();
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (txtDescuento.Text.Trim() == "")
            {
                txtDescuento.Text = "0";
            }
            
          
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtDescuento_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow.Cells["Cantidad"].Value == null || String.IsNullOrEmpty(dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString()))
            {
                MessageBox.Show("Ingrese la cantidad de productos", "Error,Cantidad vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (ValidarVacio())
                //{
                    double val2 = 0;
                    for (int i = 0; i < dgvLista.RowCount; i++)
                    {
                        string cantidad = dgvLista.Rows[i].Cells[3].Value.ToString();
                        string precio = dgvLista.Rows[i].Cells[1].Value.ToString();
                        int cant = Convert.ToInt32(cantidad);
                        double pre = Convert.ToDouble(precio);

                        double val1 = cant * pre;
                         val2 = val1 + val2;
                      
                    }
                    
                    int dec = Convert.ToInt32(txtDescuento.Text);
                    txtSubTotal.Text = val2 + "";
                    if (dec > 0)
                    {
                      double val3 = val2 * (dec / 100);
                        lblTotal.Text = (val2 - val3 ) + "";
                    }
                    else
                    {
                        lblTotal.Text = val2 + "";
                    }
                    
                    

                }
           // }
      }
    }
}
