using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm4 : System.Web.UI.Page
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
            connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            this.ListView1.DataSource = sdr;
            this.ListView1.DataBind();
            connection.Close();
        }
        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }

        protected void ListView1_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            this.ListView1.EditIndex = e.NewEditIndex;
            BindData();
            
        }

        protected void ListView1_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            this.ListView1.EditIndex = -1;
            BindData();
        }
    }
}