using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPV22022z2
{
    abstract class Let
    {
        private string polaznaDestinacija;
        private string dolaznaDestinacija;
        private DateTime datumVremePoletanja;
        private int brRezervisanihMesta;
        public Let(string polaznaDestinacija,
            string dolaznaDestinacija,
            DateTime datumVremePoletanja,
            int brRezervisanihMesta)
        {
            this.polaznaDestinacija = polaznaDestinacija;
            this.dolaznaDestinacija = dolaznaDestinacija;
            this.datumVremePoletanja = datumVremePoletanja;
            this.brRezervisanihMesta = brRezervisanihMesta;
        }
        public string PolaznaDestinacija
        {
            get { return polaznaDestinacija; }
            set { polaznaDestinacija = value; }
        }
        public int BrRezervisanihMesta
        {
            get { return brRezervisanihMesta; }
            set { brRezervisanihMesta = value; }
        }
        public string DolaznaDestinacija
        {
            get { return dolaznaDestinacija; }
            set { dolaznaDestinacija = value; }
        }
        public DateTime DatumVremePoletanja
        {
            get { return datumVremePoletanja; }
            set { datumVremePoletanja = value; }
        }
        public abstract bool Rezervacija();
    }
}
