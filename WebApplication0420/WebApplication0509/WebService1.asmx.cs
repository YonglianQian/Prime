using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetData(string s1,string s2)
        {
            //you can generate data from database according to s1,s2;
            DataTable dt = new DataTable();
            dt.Columns.Add("y", typeof(string));
            dt.Columns.Add("Points", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            DataRow dr = dt.NewRow();
            dr[0] = "2013-05-24";
            dr[1] = 4;
            dr[2] = "Data Center";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "2013-05-25";
            dr1[1] = 5;
            dr1[2] = "Data Center";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "2013-05-26";
            dr2[1] = 6;
            dr2[2] = "Data Center";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "2013-05-27";
            dr3[1] = 7;
            dr3[2] = "Data Center";
            dt.Rows.Add(dr3);
            return GetJson(dt);

        }

        public string GetJson(DataTable dt)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(dc.ColumnName, dr[dc]);
                }
                list.Add(result);
            }
            return new JavaScriptSerializer().Serialize(list);
        }
    }
    public class DataPoint
    {
        public string y { get; set; }
        public int Points { get; set; }
    }
    public  class DataClass
    {
        public string Title { get; set; }
        public DataPoint[] DataPoints { get; set; }

    }
        
}
