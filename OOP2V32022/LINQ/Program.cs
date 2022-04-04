using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date;
            DateTime d2 = date.HasValue ? date.Value : DateTime.Now;

            var products = ProductRepository.GetProducts();

            var cheaper = products.FindAll(p => p.Price < 50);
            var startWithMi = products.Where(w => w.Desc.StartsWith("mi"));

            var orderedByDescProducts = products.OrderByDescending(p => p.Id);

            var product1 = products.Find(p => p.Id == id.Value);

            /*
            Where
            Find

            FirstOrDefault
            SingleOrDefault

            OrderBy
            OrderByDescending

            Count
            StartsWith
            EndsWith
            Contains -> spora
            */
            
        }

        public static bool IsCheaper50(Product product)
        {
            if (product.Price < 50)
                return true;
            return false;
        }
    }
}
