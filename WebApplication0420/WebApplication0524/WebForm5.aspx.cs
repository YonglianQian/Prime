using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0524
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlDataSource1.FilterExpression = "";
            if (txtName.Text == "" & txtCity.Text != "")
            { SqlDataSource1.FilterExpression = "City = '{1}'"; }
            else if (txtName.Text != "" & txtCity.Text == "")
            { SqlDataSource1.FilterExpression = "FirstName = '{0}'"; }
            else if (txtName.Text != "" & txtCity.Text != "")
            { SqlDataSource1.FilterExpression = "FirstName = '{0}' and City = '{1}'"; }
        }

        protected void SqlDataSource1_Filtering(object sender, SqlDataSourceFilteringEventArgs e)
        {
            for (int i = 0; i < e.ParameterValues.Count; i++)
            {
                if (e.ParameterValues[i] == null)
                {
                    e.ParameterValues[i] = "";
                }
            }

        }

    }
}