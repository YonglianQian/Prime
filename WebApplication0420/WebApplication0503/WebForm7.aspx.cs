using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0503
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                byte[] image =new WebClient().DownloadData("https://ct.mob0.com/Styles/Fun.png");
                

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + ex.ToString()+"')", true);
                
            }
            
        }
    }
}