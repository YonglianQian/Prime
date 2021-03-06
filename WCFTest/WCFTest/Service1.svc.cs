﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFTest.Models;

namespace WCFTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        public double AddOperation(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Received Add {0},{1}", num1, num2);
            Console.WriteLine("Result: {0}", result);
            return result;
        }

        public void DoWork()
        {
        }


        public double SubOperation(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Received Substract {0},{1}", num1, num2);
            Console.WriteLine("Result: {0}", result);
            return result;
        }
    }
}
