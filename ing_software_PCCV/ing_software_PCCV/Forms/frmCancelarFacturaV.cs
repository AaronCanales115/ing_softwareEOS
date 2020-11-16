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
    public partial class frmCancelarFacturaV : Form
    {
        public frmCancelarFacturaV()
        {
            InitializeComponent();
        }
        DmVentas ventas = new DmVentas();
        DmConsultas c = new DmConsultas();
        DataTable dt = new DataTable();
        ArrayList IDS = new ArrayList();
        ArrayList CANT = new ArrayList();
        private void frmCancelarFacturaV_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ventas.verVentas(dgvMostrar,txtBuscar.Text.Trim());
        }

        private void dgvMostrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxLista.Text = "";
            MostrarProductos();
        }
   
        private void MostrarProductos()
        {
            string Fecha = dgvMostrar.CurrentRow.Cells["Fecha"].Value.ToString();
            string Factura = dgvMostrar.CurrentRow.Cells["Factura"].Value.ToString();
            string Nombre = dgvMostrar.CurrentRow.Cells["Nombre"].Value.ToString();
            string Apellido = dgvMostrar.CurrentRow.Cells["Apellido"].Value.ToString();
            lbxLista.Items.Add("Fecha: " + Fecha + "     " + "Factura: " + Factura + "\n\n");
            lbxLista.Items.Add("Cliente: " + Nombre + " " + Apellido + "\n\n");
            lbxLista.Items.Add("\n");

            string tex = " Producto \t\tPrecio \t Cantidad";
            lbxLista.Items.Add(tex);
            string id = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
            string cant = dgvMostrar.CurrentRow.Cells["Cantidad"].Value.ToString();
            int ca = Convert.ToInt32(cant);
            dt = ventas.VerProductosVentas(id);
            string nombre="", precio= "", canti = "",idN ="";
            for (int i=0;i< ca; i++)
            {
               for(int j = 0; j < 4; j++)
                {
                    idN = Convert.ToString(dt.Rows[i][0]);
                    nombre = Convert.ToString(dt.Rows[i][1]);
                    precio = Convert.ToString(dt.Rows[i][2]);
                    canti = Convert.ToString(dt.Rows[i][3]);
                }
             string dat =" "+ nombre + "\t"+precio+"\t  "+canti+"\n";
              lbxLista.Items.Add(dat);
                IDS.Add(idN);
                CANT.Add(canti);
            }
            lbxLista.Items.Add("\n");
            string Cantidad = dgvMostrar.CurrentRow.Cells["Cantidad"].Value.ToString();
            string Total = dgvMostrar.CurrentRow.Cells["Total"].Value.ToString();
            lbxLista.Items.Add("\n\nCantidad de Productos: : " + Cantidad + "\n\n");
            lbxLista.Items.Add("Total: "+ Total + "\n");
        }
        private void Eliminar()
        {
            string id = dgvMostrar.CurrentRow.Cells["ID"].Value.ToString();
            string Factura = dgvMostrar.CurrentRow.Cells["Factura"].Value.ToString();
            string Total = dgvMostrar.CurrentRow.Cells["Total"].Value.ToString();
            Console.WriteLine(id + " "+ Factura + " " + Total);
           ventas.RegistrarFacCancelada(Factura,Total,id);
          
            for(int i = 0; i < IDS.Count; i++)
            {
                string ids = IDS[i].ToString();
                string ca = CANT[i].ToString();
                ventas.CancelarF(ids,ca);
             }
            MessageBox.Show("Factura cancelada con exito","Cancelar Factura",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
