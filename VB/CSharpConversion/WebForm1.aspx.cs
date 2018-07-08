using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpConversion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool hasfile = this.FileUpload1.HasFile;
            bool hasfiles = this.FileUpload1.HasFiles;
            var postedfile = this.FileUpload1.PostedFile;
            
            ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('" + FileUpload1.HasFile + "')", true);
        }
    }
}