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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from products";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                this.GridView1.DataSource = sdr;
                this.GridView1.DataBind();
                sdr.Close();
                connection.Close();

                //SqlDataAdapter sda = new SqlDataAdapter(command);
                //sda.Fill(dt);
                //this.GridView1.DataSource = dt;
                //this.GridView1.DataBind();
            }

        }

    }
}