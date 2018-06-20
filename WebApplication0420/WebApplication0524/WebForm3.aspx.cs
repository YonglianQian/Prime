using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication0524
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            this.GridView1.DataSource = GetDataSet();
            this.GridView1.DataBind();

        }
        private DataView GetDataSet()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MapPath("~/App_Data/2.xml"));
            XmlNodeList nodelist = doc.SelectNodes("parent/child/node[@attribute='True']");
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("attribute");
            
            foreach (XmlNode node in nodelist)
            {
                DataRow dr = dt.NewRow();
                dr[0] = node.Attributes["id"].Value;
                dr[1] = node.Attributes["attribute"].Value;
                dt.Rows.Add(dr);
            }
            return dt.DefaultView;

        }
    }
}