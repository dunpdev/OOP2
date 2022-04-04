using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dogadjaji
{
    public class OrderEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
    public class Order
    {
        public delegate void OrderHandlerEvent(object source, OrderEventArgs args);
        public event OrderHandlerEvent OrderProccessed;
        public void Proccess(Product product)
        {
            Console.WriteLine($"Product {product.Id} is proccessing!");
            Thread.Sleep(5000);

            OnOrderProccessed(product);
        }

        public virtual void OnOrderProccessed(Product product)
        {
            if (OrderProccessed != null)
                OrderProccessed(this, new OrderEventArgs { Product = product });
        }
    }
}