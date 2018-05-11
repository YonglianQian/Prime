using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                string filename = FileUpload1.PostedFile.FileName;
                string path = Server.MapPath("~/ASD/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(Server.MapPath("~/ASD"));
                }
                this.FileUpload1.PostedFile.SaveAs(path + filename);

                //doing something else, such as insert the path into sqlserver

            }
        }
    }
}