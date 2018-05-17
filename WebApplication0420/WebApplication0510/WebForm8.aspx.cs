using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ProductService service = new ProductService();
        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCategory.DataSource = service.GetCategoryByProductID(ddlProduct.SelectedValue);
                ddlCategory.DataTextField = "Name";
            ddlCategory.DataValueField = "ID";
            ddlCategory.DataBind();
        }

        protected void ddlCategory_DataBound(object sender, EventArgs e)
        {
            if (ddlCategory.Items.Count>0)
            {
                ddlCategory.Items.Insert(0, "- Category -");
                ddlCategory.Items[0].Value = "";
                ddlCategory.SelectedIndex = 0;
            }
        }
    }
}