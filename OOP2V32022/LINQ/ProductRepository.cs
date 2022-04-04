using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductRepository
    {
        public static int? id;
        public static List<Product> Products { get; set; } = new List<Product>
            {
                new Product{ Id = 1, Desc = "Milka 100g", Price = 100},
                new Product{ Id = 2, Desc = "Nescaffe ", Price = 20},
                new Product{ Id = 3, Desc = "Jacobs", Price = 30}
            };
        public static List<Product> GetProducts()
        {
            return Products;
        }
        public static Product FindById()
        {
            if(id.HasValue)
              return Products.Find(p => p.Id == id.Value);
            return Products[0];
        }

        public static Product FindByDate(DateTime? date)
        {
            DateTime d2 = date.HasValue ? date.Value : DateTime.Now;
            DateTime d3 = date ?? DateTime.Now;

            return Products[0];
        }
    }
}
