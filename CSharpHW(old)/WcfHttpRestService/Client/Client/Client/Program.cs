using System;
using System.ServiceModel;
using WcfRestServiceContracts;
using System.ServiceModel.Description;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var channelFactory = new ChannelFactory<IService>(new WebHttpBinding(), "http://localhost:8000/"))
            {
                channelFactory.Endpoint.Behaviors.Add(new WebHttpBehavior());

                var channel = channelFactory.CreateChannel();

                var result = channel.ShowMessage("hello");

                Console.WriteLine(result);
            }
        }
    }
}
