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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "select OrgID,CategoryID from tblFoods";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                this.DropDownList1.DataSource = dt.DefaultView.ToTable(true, "OrgId");
                this.DropDownList1.DataTextField = "OrgID";
                this.DropDownList1.DataValueField = "OrgID";
                this.DropDownList1.DataBind();
                this.DropDownList2.DataSource = dt.DefaultView.ToTable(true, "CategoryID");
                this.DropDownList2.DataTextField = "CategoryID";
                this.DropDownList2.DataValueField = "CategoryID";
                this.DropDownList2.DataBind();
            }
        }
    }
}