using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;

namespace OOP2V9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Person person;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<Person> Persons { get; set; }
        public DB Db { get; set; }
        public Person Person
        {
            get { return person; }
            set { person = value;
                OnPropertyChanged();
            }
        }
        public MainWindow()
        {
            Persons = new ObservableCollection<Person>();
            Person = new Person();
            Db = new DB();
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Db.snimanjePodataka(Person);
            Person p = new Person()
            {
                FirstName = Person.FirstName,
                LastName = Person.LastName,
                PhoneNumber = Person.PhoneNumber,
                Email = Person.Email
            };
            Persons.Add(p);
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Db.azuriranjePodataka(Person);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Db.brisanjePodataka(Person);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataTable dt = Db.citanjePodataka();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Persons.Add(
                    new Person
                    {
                        FirstName = dt.Rows[i][0].ToString(),
                        LastName = dt.Rows[i][1].ToString(),
                        PhoneNumber = dt.Rows[i][2].ToString(),
                        Email = dt.Rows[i][3].ToString()
                    });
            }
        }
    }
}
