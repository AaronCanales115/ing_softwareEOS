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
        DmConsultas consultas = new DmConsultas();
        DmObtenerIP IP = new DmObtenerIP();
        DmLogin lg = new DmLogin();
        FrmPrincipal p = new FrmPrincipal();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            string IPM = IP.ObtenerMac();
           string ip = consultas.ConsultaSimple("SELECT IpMaquina.idUsuario FROM IpMaquina WHERE ipMaquina ='"+IPM.Trim()+"'");
          Console.WriteLine(ip);
        
            if (ip.Trim() != "")
            {
                string val = lg.LoginL();
                Console.WriteLine(val);
                if(val.Trim() == "OK")
                {
                    p.lbldato.Text = ip;
                    p.lbldato2.Text = "OK";
                    p.Show();
                    this.Close();
                    
                }else if(val.Trim() == "ERROR")
                {
                    MessageBox.Show("Sesión Cerrada, se inicio la sesión en otro dispositivo","Sesión Cerrada Automáticamente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }
    
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarN(txtUsuario.Text.Trim(), txtPass.Text.Trim());
        }
        private void IniciarN(string usuario, string clave)
        {
            string resultado = consultas.ConsultaSimple("SELECT idUsuario FROM Usuario WHERE Usuario.UserName ='" + txtUsuario.Text.Trim() + "'");
            p.lbldato.Text = resultado;
            if (cbxRemember.Checked == true)
            {
                
                string val = lg.Login(usuario,clave);
                if (val.Trim() == "OK")
                {
                    p.lbldato2.Text = "OK";
                    p.Show();
                    this.Close();
                }
              
            }
            else
            {
                
                string val = lg.Login(txtUsuario.Text.Trim(), txtPass.Text.Trim());
                if(val.Trim() == "OK")
                {
                    p.lbldato2.Text = "NO";
                    p.Show();
                    this.Close();
                    
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarN(txtUsuario.Text.Trim(), txtPass.Text.Trim());
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPass.Focus();
            }
        }
    }
}
