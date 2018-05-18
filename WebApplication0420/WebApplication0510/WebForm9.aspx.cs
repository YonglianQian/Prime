using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0510
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        
    protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = GetDataTable();
            this.GridView1.DataBind();
            
        }
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student Number", typeof(int));
            dt.Columns.Add("1", typeof(int));
            dt.Columns.Add("12", typeof(int));
            dt.Columns.Add("4", typeof(int));
            dt.Columns.Add("2", typeof(int));
            dt.Columns.Add("5", typeof(int));
            dt.Columns.Add("8", typeof(int));
            DataRow dr = dt.NewRow();
            dr[0] = 1001;
            dr[1] = 345;
            dr[2] = 8000;
            dr[3] = 567;
            dr[4] = 888;
            dr[5] = 999;
            dr[6] = 9000;
            dt.Rows.Add(dr);
            return dt;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTable();
            List<string> strlist = new List<string>();
            foreach (DataColumn item in dt.Columns)
            {
            strlist.Add(item.ColumnName);
            }

            string[] arr = strlist.ToArray();
            Array.Sort(arr, new customComparer());
            
            


            //dt = SetColumnOrder(dt, arr);
            dt=SetColumnOrder(dt, strlist.OrderBy(p => p.Normalize(), new customComparer()).ToArray());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
       
        public  DataTable SetColumnOrder(DataTable dt,params string[] columnNames)
        {
            int columnIndex = 0;
            foreach (var columnName in columnNames)
            {
                dt.Columns[columnName].SetOrdinal(columnIndex);
                columnIndex++;
            }
            return dt;
        }
    }
    public class customComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == "Student Number" || y== "Student Number")
            {
                return 1;
            }
            else
            {
                int x1 = Convert.ToInt32(x);
                int y1 = Convert.ToInt32(y);
                if (x1 > y1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
    

}