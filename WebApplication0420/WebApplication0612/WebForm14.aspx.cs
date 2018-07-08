using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
            this.TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
        }
    }
}