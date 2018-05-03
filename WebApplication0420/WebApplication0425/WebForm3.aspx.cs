using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0425
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < this.GridView1.Columns.Count; i++)
            {
                DataColumn dc = new DataColumn(this.GridView1.Columns[i].HeaderText.ToString());
                dt.Columns.Add(dc);
            }
            for (int i = 0; i < this.GridView1.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < GridView1.Columns.Count; j++)
                {
                    dr[j] = Convert.ToString(this.GridView1.Rows[i].Cells[j].Text);
                }
                dt.Rows.Add(dr);
            }

            this.GridView2.DataSource = dt;
            this.GridView2.DataBind();

        }
    }
}