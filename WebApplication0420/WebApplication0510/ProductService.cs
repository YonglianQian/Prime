using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0510
{
    public class ProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id="1",Name="Apple",CategoryName="Fruit",CategoryId="10"},
            new Product{Id="2",Name="Pear",CategoryName="Fruit",CategoryId="10" },
            new Product{Id="3",Name="Dog",CategoryName="Animal",CategoryId="20" },
            new Product{Id="4",Name="Cat",CategoryName="Animal",CategoryId="20" }
        };
        public Category GetCategoryByProductID(string id)
        {
            return products.Where(p => p.Id == id).Select(p => new Category { CategoryId = p.CategoryId, CategoryName = p.CategoryName }).FirstOrDefault();
        }

    }
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
    }
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}