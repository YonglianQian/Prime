using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC0507.Models
{
    public class ImportExcelViewModel
    {
        public string email { get; set; }
        public string RowNb { get; set; }
        public bool IsVallid { get; internal set; }
    }
}