using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using WebApplication0503.Models;

namespace WebApplication0503
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// 不推荐这种方式返回数据,当方法含有参数,前端返回JSON字符串有问题.
        /// </summary>
        /// <param name="startingValue"></param>
        [WebMethod]
        public void GetData(int startingValue)
        {
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";

            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Apple",Price=10}
                ,new Product{Id=2,Name="Pear",Price=12}
                ,new Product{Id=3,Name="Peach",Price=11}

            };
            //var jsonData = new { FirstValue = 6, SecondValue = 12 };
            string json = JsonConvert.SerializeObject(products);
            //string json = (new JavaScriptSerializer()).Serialize(jsonData);
            Context.Response.Write(json);

        }
        /// <summary>
        /// 推荐! 返回object,序列化交给框架来做.
        /// </summary>
        /// <param name="startingValue"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Product> GetData2(int startingValue)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Apple",Price=10}
                ,new Product{Id=2,Name="Pear",Price=12}
                ,new Product{Id=3,Name="Apricot",Price=11}
            };
            //var jsondata = new { FirstValue = startingValue, SecondValue =startingValue*2 };
            return products;
        }
    }
}
