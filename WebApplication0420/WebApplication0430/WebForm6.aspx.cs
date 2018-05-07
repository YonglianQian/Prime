using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0430
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HiddenField hf2  = (HiddenField)GridView1.Rows[0].FindControl("HiddenField1");
            //string value = "bind(Id): "+hf2.Value;
            WebUserControl3 control3 = (WebUserControl3)this.GridView1.Rows[0].FindControl("WebUserControl3");
            string value = control3.EventSecret;

            ClientScript.RegisterStartupScript(this.GetType(), "hehe", "alert('" + value + "')",true);
        }

        protected void GridView1_DataBinding(object sender, EventArgs e)
        {

        }
    }
}