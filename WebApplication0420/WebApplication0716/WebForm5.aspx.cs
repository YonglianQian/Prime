using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0716
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData(); 
            }
        }
        public void BindData()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataStoreConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Products";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.DropDownList1.DataTextField = "Name";
            this.DropDownList1.DataValueField = "Id";
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataBind();
        }
    }
}