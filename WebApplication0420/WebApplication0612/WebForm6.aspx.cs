using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Abrahamq\Documents\Database1.accdb;");
                conn.Open();
                OleDbCommand command = new OleDbCommand("select * from boekt", conn);
                OleDbDataReader oleDbDataReader = command.ExecuteReader();
                this.DataList1.DataSource = oleDbDataReader;
                this.DataList1.DataBind();
                oleDbDataReader.Close();
                conn.Close();
            }
        }
        protected string Handle(object ImageUrl)
        {
            string url = Convert.ToString(ImageUrl);
            return url.Trim('#');
        }
    }
}