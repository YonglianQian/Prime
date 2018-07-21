using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0716
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]{6,20}$";
            string pattern1 = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$";
            //string pattern2 = @"^(?=.*[A-Za-z0-9])[A-Za-z\d]{6,20}$";
            Regex regex = new Regex(pattern1); 
            string text = this.TextBox1.Text;
            var result = regex.IsMatch(text);
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('"+result+"')", true);
            
        }
    }
}