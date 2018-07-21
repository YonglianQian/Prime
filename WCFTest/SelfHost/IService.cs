using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    [ServiceContract(Namespace = "mydemo",Name ="demo")]
    public interface IService
    {
        [OperationContract]
        double AddOperation(double num1, double num2);
        [OperationContract]
        double SubOperation(double num1, double num2);

        [OperationContract(Name ="add",Action ="add2")]
        int Add(int a, int b);
        void work(int x, int y);

    }
}
