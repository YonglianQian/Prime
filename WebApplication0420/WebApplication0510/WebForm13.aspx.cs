using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand("select * from Products", connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                sdr.Close();
                connection.Close();
            }

        }
        /// <summary>
        /// Combine several columns in a row
        /// </summary>
        /// <param name="GridView1"></param>
        /// <param name="rows">row</param>
        /// <param name="sCol">start row </param>
        /// <param name="eCol">end row</param>
        public void GroupRow(GridView GridView1, int rows, int sCol, int eCol)
        {
            TableCell oldTc = GridView1.Rows[rows].Cells[sCol];
            for (int i = 1; i < eCol - sCol; i++)
            {
                TableCell tc = GridView1.Rows[rows].Cells[i + sCol];  //Cells[0]就是你要合并的列   
                tc.Visible = false;
                if (oldTc.ColumnSpan == 0)
                {
                    oldTc.ColumnSpan = 1;
                }
                oldTc.ColumnSpan++;
                oldTc.VerticalAlign = VerticalAlign.Middle;
            }
            oldTc.Text = "Your header";
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            GroupRow(this.GridView1, 0, 0, 2);
        }
    }
}