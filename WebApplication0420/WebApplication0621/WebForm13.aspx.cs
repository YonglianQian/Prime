using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace WebApplication0621
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\index.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            document.Open();
            document.Add(new Paragraph("Hello World From PDF\n"));
            document.Add(new Paragraph("\n"));
            PdfPTable TR = new PdfPTable(new float[] { 20, 20, 20 });
            for (int i = 0; i < 15; i++)
            {
               PdfPCell cell = new PdfPCell(new Paragraph(i.ToString()));
                TR.AddCell(cell);
            }
            document.Add(TR);
            Image image = Image.GetInstance(Server.MapPath("~/App_Data/3.png"));
            document.Add(image);
            document.Close();
        }
    }
}