using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplexChannelFactory<IService> factory = new DuplexChannelFactory<IService>(new CallbackHandler(), "test_ep");
            IService channel = factory.CreateChannel();
            Console.WriteLine("Start to Call");
            channel.PostNumber(15);
            Console.WriteLine("Call is done");
        }
    }
    [ServiceContract(Namespace = "MyDemo", ConfigurationName = "isv", CallbackContract = typeof(ICallback))]
    public interface IService
    {
        [OperationContract(Action = "post_num",IsOneWay =true)]
        void PostNumber(int n);
    }
    [ServiceContract(Namespace ="callback")]
    public interface ICallback
    {
        [OperationContract(Action = "report",IsOneWay =true)]
        void Report(double progress);
    }
    public class CallbackHandler : ICallback
    {
        public void Report(double progress)
        {
            Console.WriteLine(progress);
        }
    }
}
