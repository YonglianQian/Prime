using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCF0503
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        // 要使用 HTTP GET，请添加 [WebGet] 特性。(默认 ResponseFormat 为 WebMessageFormat.Json)
        // 要创建返回 XML 的操作，
        //     请添加 [WebGet(ResponseFormat=WebMessageFormat.Xml)]，
        //     并在操作正文中包括以下行:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public string HelloWorld()
        {
            return "Hello World";
        }

        // 在此处添加更多操作并使用 [OperationContract] 标记它们
        [OperationContract]
        [WebGet]
        public List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ID=1,Name="Apple",Price=10.00M},
                new Product{ID=2,Name="Pear",Price=18.00M}
            };
            return products;
        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
