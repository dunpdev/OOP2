using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Danas ucimo mnogo novih oblasti iz C#";
            string shorter = text.Shorter(-1);
            Console.WriteLine(shorter);

            Console.Read();
        }
    }
}
