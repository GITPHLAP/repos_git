using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace NetworkSpeed
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConnectionInfo();

            Console.ReadLine();
        }

        public static void ConnectionInfo()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface x_interface in interfaces.Where(infa => infa.OperationalStatus == OperationalStatus.Up))
            {
                Console.WriteLine("\nBeskrivelse: {0} \nId: {1} \nIsReceiveOnly: {2} \nNavn: {3} \nInterface: {4} " +
                    "\nStatus {5}" +
                    "\nHastighed (b/s)  {6}" +
                    "\nHastighed (kb/s) {7}" +
                    "\nHastighed (Mb/s) {8}" +
                    "\nHastighed (Gb/2) {9}" +
                    "\nMulticast: {10}",
                    x_interface.Description  ,
                    x_interface.Id  ,
                    x_interface.IsReceiveOnly  ,
                    x_interface.Name  ,
                    x_interface.NetworkInterfaceType  ,
                    x_interface.OperationalStatus ,
                    x_interface.Speed,
                    x_interface.Speed / 1000,
                    x_interface.Speed / 1000 / 1000,
                    x_interface.Speed / 1000 / 1000 / 1000,
                    x_interface.SupportsMulticast);

                var ipInfo = x_interface.GetIPv4Statistics();
                Console.WriteLine("QueueLength: {0}", ipInfo.OutputQueueLength);
                Console.WriteLine("BytesModtaget: {0}",ipInfo.BytesReceived);
                Console.WriteLine("BytesSent: {0}", ipInfo.BytesSent);


                if (x_interface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    x_interface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.WriteLine("****** Ethernet eller Trådløst internet - Hastighed (bits/s); {0}", x_interface.Speed);
                }
             
            }

        }
         
    }
}
