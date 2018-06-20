using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(3000);
            Label1.Text = "Page Refreshed at " + DateTime.Now.ToString();
        }
    }
}