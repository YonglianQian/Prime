using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0524
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName=="GetValue")
            {
                string Id = (e.Item.FindControl("IDLabel") as Label).Text;
                string Name = (e.Item.FindControl("NameLabel") as Label).Text;
                string Price = (e.Item.FindControl("PriceLabel") as Label).Text;
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('" + Id + " " + Name + " " + Price + "')</script>");
            }
        }
    }
}