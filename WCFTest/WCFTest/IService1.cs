using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Services;
using System.Web.UI;
using WCFTest.Models;

namespace WCFTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        double AddOperation(double num1, double num2);
        [OperationContract]
        double SubOperation(double num1, double num2);

        [OperationContract]
        List<Product> GetProducts();
        
    }
}
