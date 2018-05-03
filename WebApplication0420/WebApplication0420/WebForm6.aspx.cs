using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0420
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "Test";
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand();
                if (!Page.IsPostBack)
                {
                    LeadNameDropDownList.Items.Add(new ListItem("--Select Lead Name--", ""));
                    LeadNameDropDownList.AppendDataBoundItems = true;
                    String strConnString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    String strQuery = "select * from SalesLeads";
                    SqlConnection con = new SqlConnection(strConnString); ;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Connection = con;
                    try
                    {
                        con.Open();
                        LeadNameDropDownList.DataSource = cmd.ExecuteReader();
                        LeadNameDropDownList.DataTextField = "Company_Name";
                        LeadNameDropDownList.DataValueField = "ID";
                        LeadNameDropDownList.DataBind();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                        con.Dispose();
                    }

                }

            }
        }
        protected void LeadNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            String strConnString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string strQuery = "select * from SalesLeads where" + " ID = @ID";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@ID", LeadNameDropDownList.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                myreader.Read();
                DestinationAddress1TextBox.Text = myreader["Address_Line_1"].ToString();
                DestinationCityTextBox.Text = myreader["City"].ToString();
                DestinationPostcodeTextBox.Text = myreader["Post_Code"].ToString();
                myreader.Close();
            }
            finally
            {
                con.Close();
            }
        }
    }
}