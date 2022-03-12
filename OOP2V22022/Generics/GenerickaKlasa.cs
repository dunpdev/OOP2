using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenerickaKlasa
    {
        //public int max(int a,int b)
        //{
        //    return (a > b) ? a : b;
        //}
        public T max<T>(T a,T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
