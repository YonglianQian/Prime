using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand command = new SqlCommand("MyProcedure",connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;


            SqlParameter p1=command.Parameters.Add("@param1", System.Data.SqlDbType.Int);
            p1.Direction = System.Data.ParameterDirection.Input;
            SqlParameter p2= command.Parameters.Add("@param2", System.Data.SqlDbType.Int);
            p2.Direction= System.Data.ParameterDirection.Input;
            SqlParameter p3 = command.Parameters.Add("@param3", System.Data.SqlDbType.Int);
            p3.Direction = System.Data.ParameterDirection.Output;
            p1.Value = 6;
            p2.Value = 4;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.Label1.Text = p3.Value.ToString();
        }
    }
}