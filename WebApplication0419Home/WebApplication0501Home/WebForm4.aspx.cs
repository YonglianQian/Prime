using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0501Home
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("--Select--", ""));
                DropDownList1.AppendDataBoundItems = true;
                String strConnString = ConfigurationManager
                .ConnectionStrings["parallelConnectionString"].ConnectionString;
                String strQuery = "select name, surname from tblusers";
                MySqlConnection con = new MySqlConnection(strConnString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "surname";
                    DropDownList1.DataBind();
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

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager
.ConnectionStrings["parallelConnectionString"].ConnectionString;
            string strQuery = "select name, surname, username, password, role from tblusers where name = @name";
            MySqlConnection con = new MySqlConnection(strConnString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@name", DropDownList1.SelectedItem.Text);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;

            try
            {
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        TextBox1.Text = sdr[0].ToString();
                        TextBox2.Text = sdr[1].ToString();
                        TextBox3.Text = sdr[2].ToString();
                        TextBox4.Text = sdr[3].ToString();
                        TextBox5.Text = sdr[4].ToString();
                    }
                }
                else
                {
                    TextBox1.Text = "not found";
                }

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}