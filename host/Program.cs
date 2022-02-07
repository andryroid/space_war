using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démarrage du service.Veuillez patienter...... ");
            ServiceHost host = new ServiceHost(typeof(WCFServices.MesServices));
            host.AddServiceEndpoint(
                typeof(WCFInterface.Methodes),
                new NetTcpBinding(),
                "net.tcp://127.0.0.1:1993/SpaceWarServices"
                );

            host.Open();
            Console.WriteLine("Service en écoute");
            Console.ReadLine();
            host.Close();
        }
    }
}
