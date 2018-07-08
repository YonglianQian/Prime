using SelfhostClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfhostClient
{

    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient serviceClient = new ServiceClient();
            double v1 = 100.00d;
            double v2 = 25.03d;
            double result = serviceClient.AddOperation(v1, v2);
            Console.WriteLine("Add {0}+{1}= {2}", v1, v2, result);
            Console.WriteLine("Substract {0}-{1}={2}", v1, v2, serviceClient.SubOperation(v1,v2));
            serviceClient.Close();
        }
    }
}
