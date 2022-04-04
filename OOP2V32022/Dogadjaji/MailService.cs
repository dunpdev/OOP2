using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    public class MailService
    {
        public void OnOrderProccessed(object source, OrderEventArgs args)
        {
            Console.WriteLine($"Sending mail to customer for product {args.Product.Description}");
        }
    }
    public class SMSService
    {
        public void OnOrderProccessed(object source, OrderEventArgs args)
        {
            Console.WriteLine($"Sending message to customer for product {args.Product.Description}");
        }
    }
}
