using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPV22022z2
{
    class Program
    {
        static void Main(string[] args)
        {
            AvioKompanija a = new AvioKompanija(100);
            CarterLetovi l1 = new CarterLetovi(100, 80, "BG", "ZG",
                new DateTime(2022, 3, 15), 50);
            RedovniLetovi l2 = new RedovniLetovi(100, "NI", "BG",
                new DateTime(2022, 3, 18), 60);
            CarterLetovi l3 = new CarterLetovi(100, 80, "BG", "LJ",
                            new DateTime(2022, 4, 15), 50);
            a.DodajLet(l1);
            a.DodajLet(l2);
            a.DodajLet(l3);
            a.PoredjajPoVremenu();
            a.RezervisiKartu("NI", "BG", new DateTime(2022, 3, 18));
            Console.WriteLine(a.ToString());
            Console.ReadLine();
        }
    }
}
