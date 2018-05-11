using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0503
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        
        protected void animals_ServerChange(object sender, EventArgs e)
        {
            string value = this.animals.Value;
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + value + "')", true);
        }
    }
}