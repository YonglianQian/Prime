using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListViewAndEF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DetailsView1_InsertItem()
        {
            PhotoAlbum photoAlbum = new PhotoAlbum();
            TryUpdateModel(photoAlbum);
            if (ModelState.IsValid)
            {
                using (var myentities=new TestEntities())
                {
                    myentities.PhotoAlbums.Add(photoAlbum);
                    myentities.SaveChanges();
                }
            }
            Response.Redirect(string.Format("ManagePhotoAlbum.aspx?PhotoAlbumId={0}", photoAlbum.Id.ToString()));
        }
    }
}