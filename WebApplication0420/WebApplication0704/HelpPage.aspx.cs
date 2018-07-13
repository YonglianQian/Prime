using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0704
{
    public partial class HelpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["Id"].ToString());
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select Img from Images";
            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                Byte[] data = (Byte[])sdr["Img"];
                Response.ContentType = "application/binary;";
                Response.BinaryWrite(data);
                Response.Flush();
                Response.End();
            }
            sdr.Close();
            connection.Close();
        }
    }
}