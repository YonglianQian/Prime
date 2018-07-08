using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_load(object sender,EventArgs e)
        {

            
        }
        [WebMethod]
        public static string GetData()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select Datetime from DatetimeRecords where id=1";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            connection.Open();
            var result = Convert.ToDateTime(command.ExecuteScalar());
            connection.Close();
            //List<object> list = new List<object>();
            Data data = new Data() { dateTime = result };
            Data1 data1 = new Data1() { datatime = result.ToString() };
            //list.Add(data);
            string json = new JavaScriptSerializer().Serialize(data);
            string json1 = new JavaScriptSerializer().Serialize(data1);
            return json;
        }

    }
   public class Data
    {
        public DateTime dateTime { get; set; }
    }
    public class Data1
    {
        public string datatime { get; set; }

    }
    
}