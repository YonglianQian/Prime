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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPersonDetails("Name ASC");
            }
        }
        private void BindPersonDetails(string sortExpression)
        {
            sortExpression = sortExpression.Replace("Ascending", "ASC");
            string constr = ConfigurationManager.ConnectionStrings["LESFieldTicketConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlDataAdapter dAd = new SqlDataAdapter("select * from Records order by Name", conn))
                {
                    DataTable dTable = new DataTable();
                    dAd.Fill(dTable);
                    // Sort now
                    dTable.DefaultView.Sort = sortExpression;

                    // Bind data now
                    ListView1.DataSource = dTable;
                    ListView1.DataBind();
                }
                conn.Close();
            }
        }
        protected void SortListViewRecords(object sender, ListViewSortEventArgs e)
        {
            BindPersonDetails(e.SortExpression + " " + e.SortDirection);
        }

        protected void CancelListViewItem(object sender, ListViewCancelEventArgs e)
        {

        }

        protected void DeleteListViewItem(object sender, ListViewDeleteEventArgs e)
        {

        }

        protected void EditListViewItem(object sender, ListViewEditEventArgs e)
        {

        }

        protected void InsertListViewItem(object sender, ListViewInsertEventArgs e)
        {

        }

        protected void UpdateListViewItem(object sender, ListViewUpdateEventArgs e)
        {

        }

        protected void PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

        }

        
    }
}