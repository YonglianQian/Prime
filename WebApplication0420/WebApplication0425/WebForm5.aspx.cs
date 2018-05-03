using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0425
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public Repository repo = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                Detail detail = new Detail();
                detail.Data = this.FileUpload1.FileBytes;
                detail.Name = this.FileUpload1.FileName;
                repo.SaveDetail(detail);
            }
            this.DropDownList1.DataSource = SqlDataSource1;
            this.DropDownList1.DataTextField = "Id";
            this.DropDownList1.DataValueField= "Id";
            this.DropDownList1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Detail detail = null;
            if (this.DropDownList1.SelectedValue != null)
            {
                int id = int.Parse(this.DropDownList1.SelectedValue);
                detail = repo.Details.FirstOrDefault(p => p.Id == id);
                if (detail!=null)
                {
                string filename = detail.Name;
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
                Response.AddHeader("content-length", detail.Data.Length.ToString());
                Response.ContentEncoding = System.Text.Encoding.Default;
                Response.BinaryWrite(detail.Data);
                Response.Flush();
                Response.End();
                }
            }
        }
    }
}