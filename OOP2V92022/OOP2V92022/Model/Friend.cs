using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V92022.Model
{
    public class Friend : INotifyPropertyChanged
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
