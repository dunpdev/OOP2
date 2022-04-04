using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Kvadrat broja {a} iznosi {Kvadrat(a)}");
            // a => a * a
            Func<int, int> nasKvadrat = w => w * w;
            Console.WriteLine($"Kvadrat broja {a} izracunat preko lambda izraza je {nasKvadrat(a)}");
            // p, p*n
            Func<int, int, int> proizvod = (p, n) => p * n;
            Console.WriteLine($"Proizvod broja 2 i 5 iznosi {proizvod(2,5)}");
            Console.Read();
        }
        static int Kvadrat(int x)
        {
            return x * x;
        }
    }
}
