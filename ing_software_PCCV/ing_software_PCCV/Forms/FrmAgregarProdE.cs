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

namespace ing_software_PCCV.Forms
{
    public partial class FrmAgregarProdE : Form
    {
        public FrmAgregarProdE()
        {
            InitializeComponent();
        }
        private DmProductos ODm = new DmProductos();
        DmConsultas c = new DmConsultas();
        ArrayList arr1 = new ArrayList();
        ArrayList arr2 = new ArrayList();
        DmComprasE ce = new DmComprasE();
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

        private void mostrarProductos(string valor)
        {

            ODm.MostrarProductos(dgvMostrar, valor);
           dgvMostrar.Columns["Descripcion"].Visible = false;
            dgvMostrar.Columns["Estado"].Visible = false;
        }

        private void FrmAgregarProdE_Load(object sender, EventArgs e)
        {
            mostrarProductos("1");
            llenarCBX();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16(lblValor.Text.Trim());
            Buscar b = new Buscar();
            b.Filtrar(dgvMostrar, this.txtBuscar.Text.Trim(), valor);
        }

        private void dgvMostrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGrid();
        }
        private void DataGrid()
        {
            string talla;
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                string id = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
                string nombre = dgvMostrar.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion =  dgvMostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
                string precio = dgvMostrar.CurrentRow.Cells["Precio"].Value.ToString();
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
                    agregar(id,nombre, Convert.ToDecimal(precio.Trim()), Convert.ToInt32(cantidad));
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
        private void agregar(string id,string Nombre,decimal Precio, int existencia)
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

        private void dgvMostrar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGrid();
        }
        private void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar))
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
        private void ValidarSoloNumero(KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar))
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

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumero(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumero(e);
        }
        private bool validarNombre(string nombre)
        {
            string name;
            int a = dgvLista.Rows.Count;
            for(int i = 0;i < a; i++)
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
        private void llenarCBX()
        {
            cbxProveedor.DataSource = c.ConsultaTab("SELECT idProveedor, RazonSocial FROM Proveedor");
            cbxProveedor.DisplayMember = "RazonSocial";
            cbxProveedor.ValueMember = "idProveedor";
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
              //  if (ValidarVacio())
              //  {
                    for (int i = 0; i < a; i++)
                    {

                        string pro = cbxProveedor.SelectedValue.ToString();
                        cantidad = dgvLista.Rows[i].Cells[3].Value.ToString();
                        string id = arr1[i].ToString();
                        string tot = arr2[i].ToString();


                        ce.GuardarCompraE("1", nf, cantidad, tot, pro, id);

                        Console.WriteLine(nf + " " + pro + " " + cantidad + " " + id + " " + tot);
                    }
                    int nfa = Convert.ToInt32(nf);
                    decimal al3 = Convert.ToDecimal(lblDesc.Text.Trim());
                    if (txtDescuento.Text.Trim() != "")
                    {

                        c.Insertar("insert into Descuento (Descuento.NFactura,Descuento.Descuento,Descuento.tipo) VALUES ('" + nfa + "','" + al3 + "',1)");
                    }

                    MessageBox.Show("Compra realizada con exito", "COMPRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Show();
                }
           // }
           
        }

        private void dgvLista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          //  Console.WriteLine("Cambio");
        }

        private void dgvLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show("Error, La cantidad es mayor que la exitencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvLista.CurrentRow.Cells["Cantidad"].Value = 0;
            }
            else
            {
                decimal a = pr * ca;
                
                decimal val = Convert.ToDecimal(txtSubTotal.Text.Trim());
                if(val <= 0)
                {
                    txtSubTotal.Text = a+ "";
                    lblTotal.Text = a+ "";
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

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            decimal val = Convert.ToDecimal(txtDescuento.Text.Trim());
            if(val > 0)
            {
                decimal val1 = val / 100;
                decimal sbtotal = Convert.ToDecimal(lblTotal.Text.Trim()) * (val1);
                decimal total = sbtotal- val;
                lblDesc.Text = sbtotal+"";
                lblTotal.Text = total+"";
            }
             
        }
        private bool ValidarVacio()
        {
            string cantidad ="";
            int a = dgvLista.Rows.Count;
            for (int i = 0; i < a; i++)
            {

                string pro = cbxProveedor.SelectedValue.ToString();

                cantidad = dgvLista.Rows[i].Cells[3].Value.ToString();
                if(cantidad == "")
                {
                    return false;
                    i = a;
                    MessageBox.Show("Error, uno de los campos esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            return true;
        }
    }
       
    
}
