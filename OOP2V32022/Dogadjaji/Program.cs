using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    class Program
    {
        /*
        porudzbina obradjuje ...
        email + sms
        */
        static void Main(string[] args)
        {
            Product product = new Product 
            { 
                Id = 1, 
                Description = "Milka 100g" 
            };
            Order order = new Order(); // publisher
            MailService mail = new MailService(); // subscriber
            SMSService SMS = new SMSService(); // subscriber
            order.OrderProccessed += mail.OnOrderProccessed;
            order.OrderProccessed += SMS.OnOrderProccessed;

            order.Proccess(product);

            Console.Read();
        }
    }
}
