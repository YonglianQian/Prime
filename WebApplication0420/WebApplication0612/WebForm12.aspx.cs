using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            string text = "Procedure";
            SqlCommand command = new SqlCommand(text, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@param1", SqlDbType.Int).Value = 1;
            //SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //this.GridView1.DataSource = dt;
            //this.GridView1.DataBind();

            //or we could use sqldatareader,we should manage the connection state manually
            connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            //populate DataTable with load() method
            //dt.Load(sdr);
            this.GridView1.DataSource = sdr;
            this.GridView1.DataBind();
            sdr.Close();
            connection.Close();
        }
    }
}