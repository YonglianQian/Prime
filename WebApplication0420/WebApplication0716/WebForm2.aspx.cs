using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0716
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = GetDataTable();
                dt.Rows.Add(1, "Apple", 12);
                dt.Rows.Add(2, "Grape", 21);
                dt.Rows.Add(3, "Pear", 23);
                this.ListView1.DataSource = dt;
                this.ListView1.DataBind();
            }
        }
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Price") });
            return dt;           
        }
        //Tostring method is executed by default
        protected int Handle(object o1,object o2)
        {
            return Convert.ToInt32(o1) * Convert.ToInt32(o2);
        }
    }
}