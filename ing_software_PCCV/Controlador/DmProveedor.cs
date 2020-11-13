using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Controlador
{
    public class DmProveedor
    {
        DtProveedor oDt = new DtProveedor();
        public void VerProveedores(DataGridView data)
        {
            oDt.MostrarProveedores(data);
        }
        public void AddProveedor(string nombre, string ruc, string ubicacion, string tipo)
        {
            oDt.AgregarProveedores(nombre, ruc, ubicacion, Convert.ToInt32(tipo));
        }
        public void ModProveedor(string IdProveedor, string nombre, string ruc, string ubicacion)
        {
            oDt.ModificarProveedores(Convert.ToInt32(IdProveedor),nombre, ruc, ubicacion);
        }
        public void EliminarProveedor(string idProveedor)
        {
            oDt.EliminarProveedores(Convert.ToInt32(idProveedor));
        }
    }
}
