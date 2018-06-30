using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from People";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                this.DetailsView1.DataSource = dt;
                this.DetailsView1.DataBind();
            }
        }
    }
}