using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SelfHost
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
     class Service1 : IService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddOperation(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Received Add {0},{1}", num1, num2);
            Console.WriteLine("Result: {0}", result);
            return result;
        }
        public double SubOperation(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Received Substract {0},{1}", num1, num2);
            Console.WriteLine("Result: {0}", result);
            return result;
        }

        public void work(int x, int y)
        {
            
        }
    }
}
