using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0430
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = DateTime.Now.ToString("yyyy/MM/dd,hh:mm:ss");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label2.Text = DateTime.Now.ToString("yy-MM-dd,hh:mm:ss");
        }
    }
}