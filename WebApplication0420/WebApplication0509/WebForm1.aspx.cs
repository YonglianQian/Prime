﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0509
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebUserControl1.MyProperty2 = "DDD";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebUserControl1.MyProperty2 = "abcd";
        }

        protected void submit_ServerClick(object sender,EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Hello from code behind')",true);
        }
    }
}