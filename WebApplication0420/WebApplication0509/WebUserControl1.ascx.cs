﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0509
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Myproperty;
        }
        public string Myproperty { get; set; }

        protected void Page_PreRender(object sender,EventArgs e)
        {
            
        }
    }
}