using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0604
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imgPath2 = "D://1.png";

            this.Chart1.SaveImage(imgPath2,System.Web.UI.DataVisualization.Charting.ChartImageFormat.Png);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode("test.xls"));
            Response.ContentType = "application/vnd.ms-excel";
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);

            string headerTable = @"<Table><tr><td><img src='" + imgPath2 + @"' /></td></tr></Table>";
            Response.Write(headerTable);
            Response.Write(stringWrite.ToString());
            Response.End();
        }
    }
}