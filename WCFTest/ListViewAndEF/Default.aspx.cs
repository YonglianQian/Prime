using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListViewAndEF
{
    public partial class Default : System.Web.UI.Page
    {
        TestEntities entities = new TestEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListView1.DataBind();
        }
        public IEnumerable<PhotoAlbum> PhotoAlbumList_GetData()
        {
            return entities.PhotoAlbums;
        }

        // 返回类型可以更改为 IEnumerable，但是为了支持
        // 分页和排序，必须添加以下参数:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Picture> ListView1_GetData()
        {
            int id = int.Parse(this.DropDownList1.SelectedValue);
            return entities.Pictures.Where(p => p.PhotoAlbumId == id);
        }
    }
}