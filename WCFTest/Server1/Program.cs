using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh=new ServiceHost(typeof(MyService)))
            {
                sh.Open();
                Console.WriteLine("Server is ready");


                Console.ReadKey();
                sh.Close();
            }
        }
    }
    [ServiceContract(Namespace ="MyDemo",ConfigurationName ="isv",CallbackContract =typeof(ICallback))]
    public interface IService
    {
        [OperationContract(Action="post_num",IsOneWay =true)]
        void PostNumber(int n);
    }
    [ServiceContract(Namespace ="callback")]
    public interface ICallback
    {
        [OperationContract(Action="report",IsOneWay =true)]
        void Report(double progress);
    }
    [ServiceBehavior(ConfigurationName ="sv")]
    public class MyService : IService
    {
        public void PostNumber(int n)
        {
            ICallback callback = OperationContext.Current.GetCallbackChannel<ICallback>();
            for (int i = 0; i < n; i++)
            {
                Task.Delay(200).Wait();
                double p = Convert.ToDouble(i) / Convert.ToDouble(n);
                callback.Report(p);
            }
        }
    }
}
