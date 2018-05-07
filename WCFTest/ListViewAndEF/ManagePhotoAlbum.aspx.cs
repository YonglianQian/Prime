using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListViewAndEF
{
    public partial class ManagePhotoAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // 返回类型可以更改为 IEnumerable，但是为了支持
        // 分页和排序，必须添加以下参数:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable ListView1_GetData([QueryString("PhotoAlbumId")] int photoAlbumId)
        {
            var entity = new TestEntities();
            var pictures = entity.Pictures.Where(p => p.PhotoAlbumId == photoAlbumId);

            return pictures;

        }

        public void ListView1_InsertItem([QueryString("PhotoAlbumId")] int photoAlbumId)
        {
            Picture picture = new Picture();
            TryUpdateModel(picture);
            FileUpload fileUpload = (FileUpload)ListView1.InsertItem.FindControl("FileUpload1");
            if (!fileUpload.HasFile||fileUpload.FileName.ToLower().EndsWith(".jgp"))
            {
                CustomValidator customValidator = (CustomValidator)ListView1.InsertItem.FindControl("CustomValidator1");
                customValidator.IsValid = false;
                ModelState.AddModelError("invalid", customValidator.ErrorMessage);
            }
            if (ModelState.IsValid&&Page.IsValid)
            {
                using (var entities=new TestEntities())
                {
                    picture.PhotoAlbumId = photoAlbumId;


                    string virtualFolder = "~/Pictures/";
                    string physicalFolder = Server.MapPath(virtualFolder);
                    string filename = Guid.NewGuid().ToString();
                    string extension = System.IO.Path.GetExtension(fileUpload.FileName);

                    fileUpload.SaveAs(System.IO.Path.Combine(physicalFolder, filename + extension));
                    picture.ImageUrl = virtualFolder + filename + extension;

                    entities.Pictures.Add(picture);
                    entities.SaveChanges();
                }
            }
        }

        // id 参数名应该与控件上设置的 DataKeyNames 值匹配
        public void ListView1_DeleteItem(int id)
        {
            var entities = new TestEntities();
            Picture picture = entities.Pictures.FirstOrDefault(p => p.Id == id);
            entities.Pictures.Remove(picture);
            entities.SaveChanges();
        }
    }
}