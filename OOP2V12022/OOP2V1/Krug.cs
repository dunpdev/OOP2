using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V1
{
    class Krug
    {
        private float pp;
        public float Poluprecnik
        {
            get { return pp; }
            set { pp = value; }
        }
        public Krug()
        {
            pp = 2.76f;
        }
        public double Obim() {
            return 2 * pp * Math.PI;
        }
        public double Povrsina() {
            return pp * pp * Math.PI;
        }
    }
}
