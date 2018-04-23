using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0420
{
    public partial class FileNameSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                FileStream fs = new FileStream(@"D:\\" + DateTime.Now.ToString("yyMMddhhmmss") + ".txt", FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(i.ToString());
                    sw.Flush();
                }
                fs.Close();

                Thread.Sleep(1000);
            }

        }
    }
}