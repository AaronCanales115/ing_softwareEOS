using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ing_software_PCCV.Forms
{
    public partial class FrmIpSesion : Form
    {
        public FrmIpSesion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                Microsoft.Win32.RegistryKey rk2 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("CCV");
                string lavacalola = txtDato.Text.Trim();
                rk2.SetValue("IpModem", lavacalola, Microsoft.Win32.RegistryValueKind.String);
                Login l = new Login();
                l.ShowDialog();
                this.Close();

        }

        private void FrmIpSesion_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey rk1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("CCV");
            if (rk1 != null)
            {
                Login l = new Login();
                l.ShowDialog();
                this.Close();
            }
           
        }
    }
}
