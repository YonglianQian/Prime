using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0503
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int vint1;
        protected void Button1_Click(object sender, EventArgs e)
        {
            vint1 = 1;
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + vint1 +"')", true);
            //output 1, in html messagebox
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + vint1 + "')", true);
            //output 0, in html messagebox
        }
    }
}