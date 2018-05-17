using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter("Select * from A", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataValueField = "MainCode";
                this.DropDownList1.DataTextField = "MainCode";
                this.DropDownList1.DataBind();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maincode = this.DropDownList1.SelectedValue.ToString();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand("select @maincode+'/'+right('0000'+CAST(Max(isnull(try_cast(REPLACE(Code,@maincode+'/','')as int),0))+1 as varchar),2) from B", connection);
            command.Parameters.AddWithValue("@maincode", maincode);
            connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            sdr.Read();
            this.TextBox1.Text = sdr[0].ToString();
            sdr.Close();
            connection.Close();

        }
    }
}