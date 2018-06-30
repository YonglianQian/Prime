using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName=="Add")
            {
                TextBox textBox = e.Item.FindControl("TextBox1") as TextBox;
                int value = string.IsNullOrEmpty(textBox.Text) ? 0 : int.Parse(textBox.Text);
                value++;
                textBox.Text = value.ToString();
                
            }
        }

    }
}