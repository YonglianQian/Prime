using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8342/ServiceModelSamples/Service");
            ServiceHost selfHost=new ServiceHost(typeof(Service1),baseAddress);
            try
            {
                selfHost.AddServiceEndpoint(typeof(IService), new WSHttpBinding(), "MyService1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                Console.WriteLine("The Service is Ready.");
                Console.WriteLine("Press <enter> to termiate service");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred:{0}", ce.Message);
                selfHost.Abort();
                
            }
        }
    }
}
