﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0419Home
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1 service = new WebService1();
            //Response.Write("<script>alert('" + service.HelloWorld() + "')</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('"+service.HelloWorld()+"')</script>");
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "", "<script>alert('"+service.HelloWorld()+"')</script>",false);
        }

    }
}