using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V1
{
    class Kvadrat
    {
        private float a;
        public float Stranica
        {
            get { return a; }
            set { a = value; }
        }
        public Kvadrat()
        {
            a = 2.76f;
        }
        public double Obim()
        {
            return 4 * a;
        }
        public double Povrsina()
        {
            return Math.Pow(a,2);
        }
    }
}
