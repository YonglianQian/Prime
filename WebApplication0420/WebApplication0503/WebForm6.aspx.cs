using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0503
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Copy_Click(object sender, EventArgs e)
        {
            this.ddlSpecToCopy.Visible = true;
        }

        protected void ddlSpecToCopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlSpecToCopy.SelectedValue=="2")
            {
                this.rblSourceType.SelectedValue = "2";
            }
            else
            {
                this.rblSourceType.SelectedValue = "1";
            }
            rblSourceType_SelectedIndexChanged(rblSourceType, new EventArgs());
        }

        protected void rblSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SqlDataSource1.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            if (rblSourceType.SelectedValue == "1")
            {
                this.SqlDataSource1.SelectCommand = "Select * from Products";
                this.ddlSpecSource.DataValueField = "Id";
                this.ddlSpecSource.DataTextField = "Name";
            }
            else
            {
                this.SqlDataSource1.SelectCommand = "Select * from Persons";
                this.ddlSpecSource.DataValueField = "Id_P";
                this.ddlSpecSource.DataTextField = "FirstName";
            }
            this.SqlDataSource1.DataBind();
            this.ddlSpecSource.ClearSelection();
            this.ddlSpecSource.DataSourceID = "SqlDataSource1";
            this.ddlSpecSource.DataBind();
        }
    }
}