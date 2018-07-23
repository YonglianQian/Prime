using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0723
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = GetDataTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = "Id=2";
            this.GridView1.DataSource = dv;
            this.GridView1.DataBind();
                

        }
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id"), new DataColumn("Name") });
            dt.Rows.Add(1, "Apple");
            dt.Rows.Add(2, "Pear");
            dt.Rows.Add(3, "Grape");
            return dt;
        }
    }
}