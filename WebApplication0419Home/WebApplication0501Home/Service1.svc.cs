using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebApplication0501Home
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
        public void DoWork()
        {
            // 在此处添加操作实现
            return;
        }

        // 在此处添加更多操作并使用 [OperationContract] 标记它们
        [OperationContract]
        public string HelloWorld(string name)
        {
            return "Hi "+name+" Hello World From WCF HelloWorld";
        }
        public class Review
        {
            public int ID { get; set; }
            public string Title { get; set; }

        }
        [OperationContract]
        public List<Review> GetReviews()
        {
            List<Review> reviews = new List<Review>()
            {
                new Review{ID=1,Title="Nice Music" },
                new Review{ID=2,Title="Holy Shit" }
            };
            return reviews;
        }
    }
}
