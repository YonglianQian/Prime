using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = GetDataTable();
            this.GridView1.DataBind();
        }
        protected DataTable GetDataTable()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Products";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            this.GridView1.DataSource = GetDataTable();
            this.GridView1.DataBind();
        }
    }
}