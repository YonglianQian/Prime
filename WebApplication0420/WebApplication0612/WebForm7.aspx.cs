using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView gridView = new GridView();
            gridView.ID = "GridView1";
            gridView.Attributes["runat"] = "server";
            gridView.DataSource = GetDataTable();
            gridView.DataBind();
            this.div1.Controls.Add(gridView);

        }
        protected DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Apple";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = 2;
            dr1[1] = "Peach";
            dt.Rows.Add(dr1);
            return dt;
        }
    }
}