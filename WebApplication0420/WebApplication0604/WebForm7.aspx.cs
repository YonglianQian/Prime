using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0604
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ListView1.DataSource = GetDataTable();
                this.ListView1.DataBind();
            }

        }
        public DataTable GetDataTable()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from products";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        protected void ListView1_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            this.ListView1.EditIndex = e.NewEditIndex;
            this.ListView1.DataSource = GetDataTable();
            this.ListView1.DataBind();
            List<string> names = new List<string>();
            names.Add("Banana");
            names.Add("Mango");
            names.Add("Peach");
            names.Add("Pear");
            names.Add("Apple");
            DropDownList dropDownList = (DropDownList)ListView1.Items[e.NewEditIndex].FindControl("DropDownList1");
            for (int i = 0; i < names.Count; i++)
            {
                dropDownList.Items.Add(new ListItem(names[i]));
            }
        }
        protected void ListView1_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            
            int id = Convert.ToInt32(((Label)ListView1.Items[e.ItemIndex].FindControl("IDLabel1")).Text);
            DropDownList name = (DropDownList)ListView1.Items[e.ItemIndex].FindControl("DropDownList1");
            TextBox price = (TextBox)ListView1.Items[e.ItemIndex].FindControl("PriceTextBox");
            if (name.SelectedValue != string.Empty || price.Text != string.Empty)
            {
                string Name = name.SelectedValue;
                string Price = price.Text;
                SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand command = new SqlCommand();
                command.CommandText = "update Products Set Name=@Name,Price=@Price where Id=@id";
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@id", id);

                
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            this.ListView1.EditIndex = -1;
            this.ListView1.DataSource = this.GetDataTable();
            this.ListView1.DataBind();
        }

        protected void ListView1_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            //this.ListView1.EditIndex = -1;
            //this.ListView1.DataSource = GetDataTable();
            //this.ListView1.DataBind();

        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName=="Edit")
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Edit')", true);
            }
            if(e.CommandName=="Update")
            {
                //or we could execute update the sqlserver  command here 
                string name = ((DropDownList)ListView1.Items[e.Item.DataItemIndex].FindControl("DropDownList1")).SelectedValue;
                //ClientScript.RegisterStartupScript(this.GetType(), "", "alert('"+name+"')", true);
            }
            //or we could handle Cancel command here.
            if (e.CommandName== "Cancel")
            {

                this.ListView1.EditIndex = -1;
                this.ListView1.DataSource = GetDataTable();
                this.ListView1.DataBind();
                e.Handled = true;
            }
        }
    }
}