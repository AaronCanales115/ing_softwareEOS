using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class DmObtenerIP
    {
        public string ObtenerMac()
        {
            string Mac = "";
            foreach (NetworkInterface NIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (NIC.OperationalStatus == OperationalStatus.Up)
                {
                    Mac += NIC.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return Mac;
        }
    }
}
