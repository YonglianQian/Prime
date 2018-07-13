using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0704
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                binddata();
                BindData2();
            }
        }
        public void binddata()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Pics";
            command.Connection = connection;
            connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            this.GridView1.DataSource = sdr;
            this.GridView1.DataBind();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.FileUpload1.HasFile)
            {
                string file = FileUpload1.FileName;
                string ext = Path.GetExtension(file);
                string name = Guid.NewGuid().ToString() + ext;

                //save the path to server.
                string savepath = Server.MapPath("~/Images/") + name;
                FileUpload1.SaveAs(savepath);

                // insert path to database
                Insert("~/Images/" + name);
            }
            binddata();
        }
        public int Insert(string path)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into Pics(Path) values('" + path + "')";
            command.Connection = connection;
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                string file = e.CommandArgument.ToString();
                //first way of downloading file.
                //Response.Clear();
                //Response.ContentType = "application/x-zip-compressed";
                //Response.AddHeader("Content-Disposition", "attachment;filename=" + Path.GetFileName(file));
                //Response.TransmitFile(file);

                string filename = file;
                string FullFileName = Server.MapPath(file);
                FileInfo fi = new FileInfo(FullFileName);
                if (fi.Exists)
                {
                    Response.Clear();
                    Response.ClearHeaders();
                    Response.Buffer = false;
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment;   filename=" + HttpUtility.UrlEncode(fi.FullName, System.Text.Encoding.UTF8));
                    Response.AddHeader("Content-Length", fi.Length.ToString());
                    Response.WriteFile(fi.FullName);
                    Response.Flush();
                    Response.End();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!FileUpload2.HasFile)
            {
                Response.Write("Select a file");
                return;
            }
            else
            {
                var file = FileUpload2.PostedFile;
                string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);
                string extension = Path.GetExtension(filename);
                byte[] data = new byte[file.ContentLength];
                file.InputStream.Read(data, 0, file.ContentLength);
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into Images(Name,Extension,Img,Img_date) values(@name,@extension,@img,getdate())";
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = Guid.NewGuid().ToString();
                    cmd.Parameters.Add("@extension", SqlDbType.NVarChar).Value = extension;
                    cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = data;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
            BindData2();
        }
        public void BindData2()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Images";
            command.Connection = connection;
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            this.GridView2.DataSource = dt;
            this.GridView2.DataBind();
            connection.Close();
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{


            //    string id = (e.Row.FindControl("Label1") as Label).Text;
            //    Image imagecontrol = e.Row.FindControl("Image2") as Image;
            //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDataStore"].ConnectionString);
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = "select Name,Extension,Img from Images";
            //    connection.Open();
            //    SqlDataReader sdr = command.ExecuteReader();
            //    if (sdr.Read())
            //    {
            //        Byte[] data = (byte[])sdr["Img"];
            //        //string path = "~/Images/" + sdr["Name"] + sdr["Extension"];
            //        //string abspath = Server.MapPath(path);
            //        //if (!File.Exists(abspath))
            //        //{
            //        //    BinaryWriter bw = new BinaryWriter(File.Open(abspath, FileMode.OpenOrCreate));
            //        //    bw.Write(data);
            //        //    bw.Close();
            //        //}
            //        //imagecontrol.ImageUrl = path;
            //        imagecontrol.ImageUrl = "data:image;base64," + Convert.ToBase64String(data);
            //    }
            //    sdr.Close();
            //    connection.Close();
            //}
        }
    }
}