using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["sortdirection"] = "ASC";
                Session["LastSort"] = "Description ASC";
                ReSort();
            }
        }
        private DataSet GetDataSet()
        {
            string path = Server.MapPath("~/App_Data/2.xml");
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path, XmlReadMode.InferSchema);
            return dataSet;
        }

        protected void DataGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (GetDataSet()!=null)
            {
                DataView dv = new DataView(GetDataSet().Tables[0]);
                if (ViewState["sortdirection"].ToString()=="ASC")
                {
                    ViewState["sortdirection"] = "DESC";
                    Session["LastSort"] = e.SortExpression + " " + ViewState["sortdirection"];
                }
                else
                {
                    ViewState["sortdirection"] = "ASC";
                    Session["LastSort"] = e.SortExpression + " " + ViewState["sortdirection"];
                }
                ReSort();
            }
        }

        protected void DataGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataGridView.PageIndex = e.NewPageIndex;
            ReSort();
        }
        private void ReSort()
        {
            if (GetDataSet() != null)
            {
                DataView dv = new DataView(GetDataSet().Tables[0]);
                dv.Sort = Session["LastSort"].ToString();
                DataGridView.DataSource = dv;
                DataGridView.DataBind();

            }
        }
    }
}