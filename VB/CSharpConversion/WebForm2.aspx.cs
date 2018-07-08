using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpConversion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected static ArrayList idList = new ArrayList();
        protected static string Comp;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            //Capacitors
            Comp = "Capacitors";

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conCString1"].ConnectionString);
            string ConnString = Utils2.GetConnString();
            string querystring = string.Empty;

            querystring = "DELETE * FROM [Capacitors]";
            using (OleDbConnection conn = new OleDbConnection(ConnString))
            {
                using (OleDbCommand cmd1 = new OleDbCommand(querystring, conn))
                {
                    cmd1.CommandType = CommandType.Text;
                    conn.Open();
                    cmd1.ExecuteNonQuery(); //delete capacitors
                }
                conn.Close();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            ----CODE REMOVED FOR BREVITY----;
            Label1.Text = Cap + " Capacitors exported at " + DateTime.Now.ToString();

        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            // Introducing delay for demonstration.
            Comp = "Connectors";
            UpdatePanel2.Update();
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conCString1"].ConnectionString);
            string ConnString = Utils2.GetConnString();

            string querystring = string.Empty;

            querystring = "DELETE * FROM [Connectors]";
            using (OleDbConnection conn = new OleDbConnection(ConnString))
            {
                using (OleDbCommand cmd1 = new OleDbCommand(querystring, conn))
                {
                    cmd1.CommandType = CommandType.Text;
                    conn.Open();
                    cmd1.ExecuteNonQuery(); //delete connectors
                }
                conn.Close();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            ----CODE REMOVED FOR BREVITY----;
            Label2.Text = Con + " Connectors exported at " + DateTime.Now.ToString(); //237 at test

        }

        private void Button10_Click(object sender, System.EventArgs e)
        {

        }
    }
    public sealed class Utils2
    {
        // sealed to ensure the utility class won't be inherited
        private Utils2()
        {
        }

        public static string GetConnString()
        {
            return WebConfigurationManager.ConnectionStrings("CRAP_HOME_USE_ACCESS").ConnectionString;
        }

    }
}




