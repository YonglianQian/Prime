using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0621
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Label label = e.Item.FindControl("DescriptionLabel") as Label;
            string all = "";
            int indexss = 0;
            //display 5 rows.
            for (int i = 0; i < 5; i++)
            {
                //per row 20 character.
                all = all + label.Text.Substring(indexss, 20) + "<br>";
                indexss = indexss + 20;
            }
            label.Text = all;
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Display")
            {
                Label label = e.Item.FindControl("DescriptionLabel") as Label;
                string id = (e.Item.FindControl("IdLabel") as Label).Text;
                SqlConnection sqlconenction = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
                SqlCommand command = new SqlCommand();
                command.CommandText = "select Description from Records where id=" + id;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = sqlconenction;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string result = dt.Rows[0][0].ToString();
                string all = "";
                int index = 0;
                for (int i = 0; i < result.Length/20; i++)
                {
                    all += result.Substring(index, 20) + "<br>";
                    index += 20;
                }
                label.Text = all;
            }

        }
    }
}