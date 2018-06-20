using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0612
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<System.Drawing.Image> images = getimage_folder();
            foreach (var item in images)
            {
                string path = "Upload/" + Guid.NewGuid().ToString() + ".png";
                item.Save(Server.MapPath(path));
                Image image1 = new Image();
                image1.ImageUrl = path;
                this.div1.Controls.Add(image1);
            }
            
        }
        public List<System.Drawing.Image> getimage_folder()
        {
            //System.Drawing.Image img = null;
            string[] filePaths = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Images"));
            List<System.Drawing.Image> imgfile = new List<System.Drawing.Image>();

            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);

                // files.Add(new ListItem(fileName, "~/Images/" + fileName));
                // img.Save(filePath);
                // Bitmap image1 = (Bitmap)System.Drawing.Image.FromFile(filePath, true);
                System.Drawing.Image image1 = (System.Drawing.Image)System.Drawing.Image.FromFile(filePath, true);
                imgfile.Add(image1);

            }
            return imgfile;
        }
    }
}