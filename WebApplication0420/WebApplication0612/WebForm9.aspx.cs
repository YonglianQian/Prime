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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListView1.ItemPlaceholderID = "MyLayout$ItemPlaceHolder";
            ListView1.LayoutCreated += new EventHandler(ListView_LayoutCreated);
            ListView1.LayoutTemplate = LoadTemplate("Layout.ascx");
            ListView1.ItemTemplate = LoadTemplate("ItemTemplate.ascx");


            ListView1.DataSource = GetDataTable();
            ListView1.DataBind();
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
        protected void ListView_LayoutCreated(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            listView.Controls.RemoveAt(0);
            Control layoutcontainer = new Control();
            ListView1.LayoutTemplate.InstantiateIn(layoutcontainer);
            var usecontrol = layoutcontainer.Controls[0];
            usecontrol.ID = "MyLayout";
            ListView1.Controls.Add(layoutcontainer);
        }
    }
}