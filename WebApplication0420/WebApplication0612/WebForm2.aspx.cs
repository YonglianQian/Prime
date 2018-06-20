using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IssueNumber");
                DataRow row = dt.NewRow();
                row[0] = 11;
                dt.Rows.Add(row);
                DataRow row1 = dt.NewRow();
                row1[0] = 12;
                dt.Rows.Add(row1);
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind(); 
            }

        }
        protected void GetSelectedRecords(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[1] { new DataColumn("IssueSubject") });
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        string IssueSubject = (row.Cells[1].FindControl("Number") as Label).Text;
                        dt.Rows.Add(IssueSubject);
                    }
                }
            }

            if (dt.Rows.Count == 0)
            {
                //ButtonWord.Visible = false;
                gvSelected.Visible = false;

            }
            else
            {
                gvSelected.Visible = true;
                //ButtonWord.Visible = true;
                gvSelected.DataSource = dt;
                gvSelected.DataBind();
            }
        }

        protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}