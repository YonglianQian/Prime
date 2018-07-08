using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0704
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Price") });
                dt.Rows.Add(1, "Apple", 13);
                dt.Rows.Add(2, "Pear", 23);
                dt.Rows.Add(3, "Mango", 16);
                this.ListView1.DataSource = dt;
                ListView1.DataBind(); 


            }
        }


    }
}