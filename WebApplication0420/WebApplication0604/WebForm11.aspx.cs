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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Products";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MyPnList.DataSource = dt;
            MyPnList.DataBind();
        }

        protected void MyPnList_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
        protected void AcceptButton_Click(object source, EventArgs e)
        {

        }
        protected void Decline_Click(object source, EventArgs e)
        {

        }

        protected void lnkbtnPgFirst_Click(object sender, EventArgs e)
        {

        }

        protected void lnkbtnPgPrevious_Click(object sender, EventArgs e)
        {

        }

        protected void DataListPaging_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void DataListPaging_ItemDataBound(object sender, DataListItemEventArgs e)
        {

        }

        protected void DataListPaging_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lnkbtnPgNext_Click(object sender, EventArgs e)
        {

        }

        protected void lnkbtnPgLast_Click(object sender, EventArgs e)
        {

        }
        protected void Pagingbtn_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}