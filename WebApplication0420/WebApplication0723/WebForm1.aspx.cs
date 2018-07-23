using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace WebApplication0723
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.Chart1.DataSource = GetDataTable();
            this.Chart1.Series[0].ChartType = SeriesChartType.Spline;
            this.Chart1.Series[0].XValueMember = "Id";
            this.Chart1.Series[0].YValueMembers = "Price";

            this.Chart1.DataBind();
        }
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id"), new DataColumn("Name"),new DataColumn("Price") });
            dt.Rows.Add(new TimeSpan(12,36,39), "Peach", 12);
            dt.Rows.Add(new TimeSpan(12, 37, 39), "Apple", 15);
            dt.Rows.Add(new TimeSpan(12, 38, 39), "Grape", 18);
            dt.Rows.Add(new TimeSpan(13, 23, 12), "Pear", 23);
            dt.Rows.Add(new TimeSpan(13, 24, 12), "Mango", 24);
            dt.Rows.Add(new TimeSpan(13, 25, 12), "banana", 18);
            dt.Rows.Add(new TimeSpan(13, 26, 12), "Apricot", 29);
            dt.Rows.Add(new TimeSpan(13, 28, 12), "Berry", 34);

            return dt;
        }
    }
}