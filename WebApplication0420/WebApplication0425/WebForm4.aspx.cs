using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0425
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "myscript", "<script>test2()</script>");
            //ClientScriptManager cs = Page.ClientScript;
            //cs.RegisterStartupScript(this.GetType(), "testPage", "<script>test3()</script>");

            //Button1.Attributes.Add("onclick", "return test3()");
        }
    }
}