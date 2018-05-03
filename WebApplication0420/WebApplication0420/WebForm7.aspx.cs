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
    public partial class WebForm7 : System.Web.UI.Page
    {
        //private SalesLeadsRepository _repo;
        //private SalesLeadsRepository repo
        //{
        //    get
        //    {
        //        if (_repo == null)
        //        {
        //            _repo = new SalesLeadsRepository();
        //        }
        //        return _repo;
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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


                    //if (!IsPostBack)
                    //{
                    //    string sql;
                    //    Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                    //    sql = "Select ID, Location from Location WHERE ID = '3' OR ID = '2' OR ID = '6' OR ID = '5' ORDER BY Location ASC";
                    //    cmd = new SqlCommand(sql, sqlConnection);
                    //    sqlConnection.Open();
                    //    StartingLocationDropDownList.Items.Add(new ListItem("--Please Select--", ""));
                    //    StartingLocationDropDownList.AppendDataBoundItems = true;
                    //    StartingLocationDropDownList.DataSource = cmd.ExecuteReader();
                    //    StartingLocationDropDownList.DataTextField = "Location";
                    //    StartingLocationDropDownList.DataValueField = "ID";
                    //    StartingLocationDropDownList.DataBind();
                    //    sqlConnection.Close();
                    //}
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



        void Page_PreRender(object obj, EventArgs e)
        {
            ViewState["update"] = Session["update"];
        }

    }
}
