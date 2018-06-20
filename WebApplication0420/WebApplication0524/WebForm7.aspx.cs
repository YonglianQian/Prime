using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0524
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table  border='1'>");
            sb.Append("<tr>");
            foreach (DataColumn headerColumn in GetDatatable().Columns)
            {
                sb.Append("<th>");
                sb.Append(headerColumn.ColumnName);
                sb.Append("</th>");
            }
            sb.Append("</tr>");
            foreach (DataRow row in GetDatatable().Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn dtcolumn in GetDatatable().Columns)
                {
                    sb.Append("<td>");
                    sb.Append(row[dtcolumn.ColumnName]);
                    sb.Append("</td>");
                }
                sb.Append("</tr>");

            }
            sb.Append("</table>");
            string s1 = sb.ToString();
            sb.Append("<newpage />");
            sb.Append(s1);
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + "abcd" + "_Seating.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringReader sr = new StringReader(sb.ToString());
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 0f);
            HTMLWorkExtended htmlparser = new HTMLWorkExtended(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();

        }
        public DataTable GetDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("City", typeof(string));

            DataRow dr = dt.NewRow();
            dr[0] = "Abraham";
            dr[1] = "London";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "Clauss";
            dr1[1] = "Beijing";
            dt.Rows.Add(dr1);
            return dt;
        }
    }
    public class HTMLWorkExtended : HTMLWorker
    {
        public HTMLWorkExtended(IDocListener document) : base(document)
        {
        }

        public override void StartElement(string tag, IDictionary<string, string> attrs)
        {
            if (tag.Equals("newpage"))
            {
                document.Add(Chunk.NEXTPAGE);
            }
            else
            {
                base.StartElement(tag, attrs);
            }
        }
    }
}