using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication0509
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
        //[ScriptMethod(ResponseFormat=ResponseFormat.Json)]
        public void GetData()
        {
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            List<DataClass> data = new List<DataClass>()
            {
                new DataClass{y="2013-05-24",Points=4},
                new DataClass{y="2013-05-25",Points=5},
                new DataClass{y="2013-05-26",Points=6 },
                new DataClass{y="2013-05-27",Points=7 }
            };
            string json = new JavaScriptSerializer().Serialize(data);
            Context.Response.Write(json);
            //return json;
        }
    }
    public class DataClass
    {
        public string y { get; set; }
        public int Points { get; set; }
    }
        
}
