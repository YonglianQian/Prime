using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.Label1.Text = MyProperty2;
        }


        public string MyProperty2
        {
            get
            {
                object o = ViewState["MyProperty2"];
                if (o != null)
                {
                    return (string)o;
                }
                return string.Empty;
            }
            set
            {
                ViewState["MyProperty2"] = value;
            }
        }
        public string MyProperty1 { get; set; }
    }
}