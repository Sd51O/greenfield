using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{

    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService()
        {
            this.products = new List<Product>();
        }
        public bool Delete(int id)
        {
            Product product = this.GetById(id);
            products.Remove(product);
            return true;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { PId = 1, Title = "Jasmine", Description = "Fragnance", UnitPrice = 32, Quantity = 30, ImageUrl = "/images/Jasmine.jpg" });
            products.Add(new Product { PId = 2, Title = "Rose", Description = "Love", UnitPrice = 12, Quantity = 80, ImageUrl = "/images/Rose.jpg" });
            products.Add(new Product { PId = 4, Title = "Lotus", Description = "Worship", UnitPrice = 40, Quantity = 70, ImageUrl = "/images/Lotus.jpg" });
            products.Add(new Product { PId = 1, Title = "Lily", Description = "Beautiful", UnitPrice = 20, Quantity = 100, ImageUrl = "/images/Lily.jpg" });
            return products;
        }

        public Product GetById(int id)
        {
            foreach (Product product in products)
            {
                if (product.PId == id)
                {
                    return product;
                }

            }
            return null;
        }

        public bool Insert(Product product)
        {
            products.Add(product);
            return true;
        }

        public bool Update(Product product)
        {
            Product product1 = GetById(product.PId);
            products.Remove(product1);
            products.Add(product);
            return true;
        }
    }
}
    
