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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();  
            }
        }
        protected void BindData()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Products";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();

        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName=="Delete")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "Delete from Products where Id=" + e.CommandArgument;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + command.ExecuteNonQuery() + " Effected ')", true);
                connection.Close();
                BindData();
            }
            if (e.CommandName=="Update")
            {
                TextBox name = e.Item.FindControl("TextBox1") as TextBox;
                TextBox price = e.Item.FindControl("TextBox2") as TextBox;
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "Update Products set Name='" + name.Text + "',Price=" + price.Text + " where Id=" + e.CommandArgument;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + command.ExecuteNonQuery() + " effected')", true);
                connection.Close();
                BindData();
            }
        }
    }
}