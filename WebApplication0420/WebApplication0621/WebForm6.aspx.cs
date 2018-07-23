using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication0621
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = GetDataSet();
                GridView1.DataBind();
                ViewState["sortdirection"] = "ASC";
            }
        }
        protected DataSet GetDataSet()
        {
            string path = Server.MapPath("~/App_Data/1.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(path, XmlReadMode.InferSchema);
            return ds;
        }
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (GetDataSet()!=null)
            {
                DataView dv = new DataView(GetDataSet().Tables[0]);
                if (ViewState["sortdirection"].ToString()=="ASC")
                {
                    dv.Sort = e.SortExpression + " DESC";
                    ViewState["sortdirection"] = "DESC";
                }
                else
                {
                    dv.Sort = e.SortExpression + " ASC";
                    ViewState["sortdirection"] = "ASC";

                }
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.GridView1.DataSource = GetDataSet();
            this.GridView1.DataBind();
        }
    }
}