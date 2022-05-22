using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace OOP2V8Z3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Studenti { get; set; }
        public Student StudentZaDodavanje { get; set; }
        public MainWindow()
        {
            Studenti = new ObservableCollection<Student>()
            {
                new Student{ Ime = "Vahid", Prezime = "Uglic",
                    Telefon="0633333", GodinaStudija=2},
                new Student{ Ime = "Belkisa", Prezime = "Dazdarevic",
                    Telefon="063321333", GodinaStudija=3},
                new Student{ Ime = "Ermin", Prezime = "Bronja",
                    Telefon="063333312", GodinaStudija=2}
            };
            StudentZaDodavanje = new Student
            {
                Ime = "",
                Prezime = "",
                Telefon = "",
                GodinaStudija = 1
            };
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student
            {
                Ime = StudentZaDodavanje.Ime,
                Prezime = StudentZaDodavanje.Prezime,
                Telefon = StudentZaDodavanje.Telefon,
                GodinaStudija = 1
            };
            Studenti.Add(s);
            StudentZaDodavanje.Ime = "";
            StudentZaDodavanje.Prezime = "";
            StudentZaDodavanje.Telefon = "";
        }

        private void Snimanje()
        {
            string txt="";
            foreach (var s in Studenti)
                txt += s.ToString();
            File.WriteAllText("DUNP.txt", txt);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Snimanje();
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value;
                OnPropertyChanged();
            }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value;
                OnPropertyChanged();
            }
        }

        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value;
                OnPropertyChanged();
            }
        }

        public int GodinaStudija { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return $"{ime} {prezime} {telefon} {GodinaStudija}";
        }
    }
}
