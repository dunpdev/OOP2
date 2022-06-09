using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP2V10.View
{
    /// <summary>
    /// Interaction logic for pageVlasnici.xaml
    /// </summary>
    public partial class pageVlasnici : Page, INotifyPropertyChanged
    {
        private ObservableCollection<Vlasnik> vlasnici;
        public ObservableCollection<Vlasnik> Vlasnici
        {
            get { return vlasnici; }
            set { vlasnici = value; }
        }
        private Vlasnik vlasnik;
        public Vlasnik Vlasnik 
        {
            get { return vlasnik; }
            set { vlasnik = value;
                OnPropertyChanged();
            }
        }
        ParkingDbEntities context = new ParkingDbEntities();
        public pageVlasnici()
        {
            Vlasnik = new Vlasnik();
            Vlasnici = new ObservableCollection<Vlasnik>();
            var tempVlasnici = context.Vlasniks.ToList();
            foreach (var v in tempVlasnici)
              Vlasnici.Add(v);
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Vlasniks.Add(Vlasnik);
                context.SaveChanges();
                Vlasnik v = new Vlasnik { Ime = Vlasnik.Ime, Prezime = Vlasnik.Prezime };
                Vlasnici.Add(v);
                Vlasnik.Ime = "";
                Vlasnik.Prezime = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
