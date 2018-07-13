using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0704
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public DataTable GetDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("ZIP") });
            dt.Rows.Add(1, "Apple", "123456");
            dt.Rows.Add(2, "Pear", "345454");
            dt.Rows.Add(3, "Grape", "23xg23");
            return dt;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            check(GetDatatable());
        }
        public bool check(DataTable dt)
        {
            string ZIPCode = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ZIPCode = dt.Rows[i].ItemArray[2].ToString();
                if (!Regex.IsMatch(ZIPCode, @"^\d{6}$"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Please input correct string, Error occurs in Row " + i + "')", true);
                    return false;
                }
            }
            return true;
        }
    }
}