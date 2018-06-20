using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Button button = new Button();
            button.ID = "Button1";
            button.Text = "Click";
            button.Click += new EventHandler(Button1_Click);
            this.Placeholder1.Controls.Add(button);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            //button.ID = "Button1";
            //button.Text = "Click";
            //button.Click += new EventHandler(Button1_Click);
            //this.Placeholder1.Controls.Add(button);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}