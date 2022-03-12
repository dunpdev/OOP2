using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V22022
{
    class Racunar
    {
        private Random r = new Random();
        private int broj;
        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        public Racunar()
        {
            GenBroj();
        }
        public void GenBroj(){
            Broj = r.Next(1, 10);
        }
    }
}
