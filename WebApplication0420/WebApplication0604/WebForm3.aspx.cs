using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0604
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            
            SqlCommand command = new SqlCommand();
            command.CommandText = "select Name,Price,(select sum(Price) from Product )AS total from Product";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            this.Chart1.DataSource = dt;
            this.Chart1.DataBind();
            this.Chart1.Titles[1].Text = dt.Rows[0]["total"].ToString();
        }
    }
}