using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Controlador
{
    public class DmArchivo
    {
        TextWriter escribir = new StreamWriter("C://Text//data.temp");
        public void dataW(string Data1, string Data2) {
            escribir.WriteLine(Data1);
            escribir.WriteLine(Data2);
            escribir.Close();

            Console.WriteLine("Dato Guardado");
        }
        public Boolean dataR()
        {
            TextReader leer = new StreamReader("C://Text//data.temp");
            string data1 = leer.ReadLine();
            string data2 = leer.ReadToEnd();
            Console.WriteLine(data1 + " -- "+ data2);
            leer.Close();
            if (data2.Trim() == "NO")
            {
                DmLogin log = new DmLogin();
                log.CerrarSesion(data1.Trim());
                return false;
            }
            else
            {
                return true;
            }
         
        }

    }
}
