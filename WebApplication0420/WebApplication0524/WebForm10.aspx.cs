using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0524
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string handle(object text)
        {
            DateTime dateTime = Convert.ToDateTime(text);
            return dateTime.ToShortTimeString();
        }
    }
}