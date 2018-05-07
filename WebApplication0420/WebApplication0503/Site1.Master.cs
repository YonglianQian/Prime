using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication0503
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HtmlGenericControl mymodal = (HtmlGenericControl)ContentPlaceHolder1.FindControl("div1");
            //mymodal.InnerText = "Hello World";
            WebUserControl1 userControl1 = (WebUserControl1)ContentPlaceHolder1.FindControl("WebUserControl1");
            GridView gridView = (GridView)userControl1.FindControl("GridView1");
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "shanghai";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = 2;
            dr1[1] = "Beijing";
            dt.Rows.Add(dr1);
            gridView.DataSource = dt;
            gridView.DataBind();
        }
    }
}