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
namespace ing_software_PCCV
{
    public partial class Login : Form
    {
        DmLogin lg = new DmLogin();
        FrmPrincipal p = new FrmPrincipal();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarN();
        }
        private void IniciarN()
        {
            if(cbxRemember.Checked == true)
            {

            }
            else
            {
               string val = lg.Login(txtUsuario.Text.Trim(), txtPass.Text.Trim());
                if(val.Trim() == "OK")
                {
                    p.Show();
                    this.Close();
                    
                }


            }
        }
    }
}
