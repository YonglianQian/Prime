using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0604
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }

        }

       private void Bind()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Rows.Add();
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        [WebMethod]
        public static string GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            DataRow dr = dt.NewRow();
            dr[0] = "Apple";
            dr[1] = "18";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "Pear";
            dr1[1] = "10";
            dt.Rows.Add(dr1);
            ds.Tables.Add(dt);

            return ds.GetXml();
        }
    }
}