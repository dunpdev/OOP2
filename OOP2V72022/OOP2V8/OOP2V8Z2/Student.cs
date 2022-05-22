using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OOP2V8Z2
{
    public class Student : INotifyPropertyChanged
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        private int godinaStudija;
        public int GodinaStudija
        {
            get { return godinaStudija; }
            set { 
                godinaStudija = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
