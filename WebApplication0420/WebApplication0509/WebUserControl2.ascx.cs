using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0509
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.SelectParameters["EventId"].DefaultValue = Guid.Parse("cbd7084f-75bc-446d-a476-171d34830595").ToString();

        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            Response.Write("Please run"); //I do not run, why is that? help
            SqlDataSource1.UpdateParameters["EventId"].DefaultValue = Guid.Parse("cbd7084f-75bc-446d-a476-171d34830595").ToString();
            SqlDataSource1.UpdateParameters["EventName"].DefaultValue = ((TextBox)DetailsView1.FindControl("TextBox1")).Text;
            SqlDataSource1.UpdateParameters["EventSecret"].DefaultValue = ((TextBox)DetailsView1.FindControl("TextBox2")).Text;
            SqlDataSource1.UpdateParameters["JustABit"].DefaultValue = ((CheckBox)DetailsView1.FindControl("CheckBox1")).Text;
            SqlDataSource1.Update();
            DetailsView1.DataBind();
        }

   
    }
}