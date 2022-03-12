using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V22022
{
    class Igrac
    {
        private int broj;
        private string ime;
        public int Broj{
            get { return broj; }
            set { 
                if(value >= -1 && value <= 10)
                broj = value; }
        }
        public string Ime{
            get { return ime; }
            set { ime = value; }
        }
        public Igrac(){
            ime = "Tarik";
        }
        public void GenBroj(){
            Console.WriteLine("Unesite jedan broj (1 do 10)");
            var brojTekst = Console.ReadLine();
            Broj = int.Parse(brojTekst);
        }
    }
}
