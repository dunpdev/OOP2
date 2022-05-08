using System.Collections.Generic;

namespace OOP2V06Z2
{
    public class Stavka
    {
        public Stavka()
        {
            PodStavke = new List<Stavka>();
        }
        public string Naziv { get; set; }
        public List<Stavka> PodStavke { get; set; }
    }
}
