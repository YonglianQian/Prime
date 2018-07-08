using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    [ServiceContract(Namespace = "http://hehe")]
    public interface IService
    {
       
        [OperationContract]
        double AddOperation(double num1, double num2);
        [OperationContract]
        double SubOperation(double num1, double num2);


    }
}
