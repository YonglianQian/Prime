//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListViewAndEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ToolTip { get; set; }
        public string ImageUrl { get; set; }
        public int PhotoAlbumId { get; set; }
    
        public virtual PhotoAlbum PhotoAlbum { get; set; }
    }
}
