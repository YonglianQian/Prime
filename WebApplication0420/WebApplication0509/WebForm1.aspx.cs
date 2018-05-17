using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0509
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo di = new DirectoryInfo(@"D:\Images");
            //Get all classifications
            var categories = di.GetFiles().Select(p => p.Name.Split('_')[0]).Distinct(); 

            //one classification generates one picture
            foreach (string category in categories)
            {
                List<string> filelist = new List<string>();
                int width = 0;
                int height = 0;
                int Imgwidth = 0;
                foreach (var item in di.GetFiles())
                {
                    if (item.Name.Split('_')[0]==category)
                    {
                        filelist.Add(item.FullName);
                        System.Drawing.Image img = System.Drawing.Image.FromFile(item.FullName);
                        width += img.Width;
                        if (img.Height>height)
                        {
                            height = img.Height;
                        }
                    }
                }
                Bitmap bmp = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(bmp);
                foreach (var item2 in filelist)
                {
                    System.Drawing.Image img1 = System.Drawing.Image.FromFile(item2.ToString());
                    g.DrawImage(img1, new Rectangle(Imgwidth, 0, img1.Width, img1.Height));
                    Imgwidth += img1.Width;
                }
                bmp.Save(@"D:\Images\" + category + ".jpg", ImageFormat.Jpeg);
            }                       

        }
    }
}