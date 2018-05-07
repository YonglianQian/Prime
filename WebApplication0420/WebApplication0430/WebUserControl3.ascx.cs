using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0430
{
    public partial class WebUserControl3 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string Text
        {
            get
            {
                return this.Label1.Text;
            }
            set
            {
                this.Label1.Text = value;
            }
        }

        public string EventSecret { get => _eventSecret; set => _eventSecret = value; }

        private string _eventSecret;

    }
}