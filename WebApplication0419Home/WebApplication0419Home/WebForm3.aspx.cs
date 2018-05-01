using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0419Home
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.CheckBox1.Checked)
            {
                Button Btn = new Button();
                Btn.Width = 80;
                Btn.Height = 30;
                Btn.ID = "Button1";
                Btn.Text = "Button1";
                this.phProfile.Controls.Add(Btn);
                this.mp1.TargetControlID = "Button1";
            }
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.CheckBox1.Checked)
            {
                this.mp1.TargetControlID = "HF";
            }
            
        }
    }
}