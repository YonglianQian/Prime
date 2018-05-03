using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication0430
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
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetData()
        {
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Apple",Price=10}
                ,new Product{Id=2,Name="Pear",Price=12}
                ,new Product{Id=3,Name="Peach",Price=11}

            };

            string json = JsonConvert.SerializeObject(products);


            Context.Response.Write(json);
        }
    }
}
