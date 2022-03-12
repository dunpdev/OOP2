using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V22022
{
    class Igra
    {
        Igrac igrac = new Igrac();
        Racunar racunar = new Racunar();
        public void Igraj()
        {
            int brPogodaka = 0, brGenerisanja = 0;
            // IGRA
            while (true)
            {
                igrac.GenBroj();
                if (igrac.Broj == -1)
                    break;
                racunar.GenBroj();
                if(igrac.Broj == racunar.Broj)
                {
                    brPogodaka++;
                }
                brGenerisanja++;
            }
            float procenat = (float)brPogodaka / brGenerisanja * 100;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Igrac {igrac.Ime} je pogodio broj {brPogodaka} i ostavio uspesnost {procenat}%");
        }
    }
}
