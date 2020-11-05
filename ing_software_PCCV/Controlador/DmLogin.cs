using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace Controlador
{
    public class DmLogin
    {
        DtLogin log = new DtLogin();
        DmObtenerIP ip = new DmObtenerIP();
        public string Login(string User, string Pass)
        {
            string IP = ip.ObtenerMac();
           
            string result = log.LoginN(User,Pass,IP);
           // Console.WriteLine(result + "agasg");
            if(result.Trim() == "O")
            {
                return "OK";
            }
            else
            {
                if (result.Trim() == "A")
                {
                    MessageBox.Show("Error, El usuario o contraseña son incorrectos", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (result.Trim() == "B")
                    {
                        MessageBox.Show("Error, Ya se encuentra iniciada la sesión", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return  result;

        }
        public void CerrarSesion(string id)
        {
            int ID = Convert.ToInt32(id);
            log.CerrarSesion(ID);
        }
        public void MantenerSesion(string id)
        {
            int ID = Convert.ToInt32(id);
            log.MantenerSesion(ID);
        }
        public string Loginl(string User, string Pass)
        {
            string IP = ip.ObtenerMac();

            string result = log.LoginN(User, Pass, IP);
            // Console.WriteLine(result + "agasg");
            if (result.Trim() == "O")
            {

                return "OK";
            }
            else
            {
                if (result.Trim() == "A")
                {
                    MessageBox.Show("Error, El usuario o contraseña son incorrectos", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (result.Trim() == "B")
                    {
                        MessageBox.Show("Error, Ya se encuentra iniciada la sesión", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return result;

        }
        public string LoginL()
        {
            string IP = ip.ObtenerMac();
            string res = log.LoginL(IP);
            if(res.Trim() == "O")
            {
                return "OK";
            }
            return "NO";
            
        }

    }
}
