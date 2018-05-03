using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0430
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("City"));
            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "NewYork";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "2";
            dr1[1] = "Shanghai";
            dt.Rows.Add(dr1);
            WebUserControl1 userControl1 = Page.FindControl("WebUserControl1") as WebUserControl1;
            GridView gridView = userControl1.FindControl("GridView1") as GridView;
            gridView.DataSource = dt;
            gridView.DataBind();
                
        }
    }
}