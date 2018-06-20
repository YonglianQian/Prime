using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0524
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string  ProcessTransaction(string id)
        {
            string message = "";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlTransaction transaction= connection.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.CommandText = "delete from MyTime where Id=" + id;
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.Transaction = transaction;
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                message = "Delete operation succeeded";
            }
            catch (Exception)
            {
                transaction.Rollback();
                message = "An error occurred";
            }
            finally
            {
                connection.Close();
            }
            return message;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            string id = this.TextBox1.Text;
            if (!string.IsNullOrEmpty(id))
            {
                message=ProcessTransaction(id);
            }
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + message + "')", true);
        }
    }
}