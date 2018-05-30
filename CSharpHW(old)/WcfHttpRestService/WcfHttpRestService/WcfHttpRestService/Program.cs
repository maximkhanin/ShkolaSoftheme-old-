using System;
using System.ServiceModel.Web;
using WcfRestServiceContracts;
using WcfHttpRestServiceImplementation;
using System.ServiceModel;

namespace WcfHttpRestService
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/"));
            host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");

            host.Open();
            Console.WriteLine(host.BaseAddresses);
            
            Console.WriteLine("Service is running");
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();

            host.Close();
        }
    }
}
