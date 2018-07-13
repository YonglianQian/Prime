using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0704
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public List<Product> GetProducts()
        {
            DataStoreEntities dataStoreEntities = new DataStoreEntities();
            return dataStoreEntities.Products.ToList();
        }
        public void UpdateProduct(int id, string name, int price)
        {
            DataStoreEntities entities = new DataStoreEntities();
            var product = entities.Products.FirstOrDefault(x => x.Id == id);
            product.Name = name;
            product.Price = price;
            entities.SaveChanges();

        }

    }
}