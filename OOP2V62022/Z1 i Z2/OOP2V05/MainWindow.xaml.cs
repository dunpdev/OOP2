using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace OOP2V05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodavanjeStavke();
        }

        private void DodavanjeStavke()
        {
            listBox1.Items.Add(textBox1.Text); // dodaje se stavka u listBox(ono sto unese korisnik u textBox)
            textBox1.Text = ""; // obrise se tekst iz textBox-a moze da se uradi na vise nacina ovo je prvi
            //textBox1.Text = "";  // ovo je drugi nacin
            //textBox1.Clear(); // ovo je treci nacin
            textBox1.Focus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            FileStream fs = new FileStream(
               "podaci.txt",
               FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(fs); // kreira se streamReader nad kreiranom vezom
            while (!r.EndOfStream) // while petlja ide dok se ne dodje do kraja ucitavanja iz datoteke
                listBox1.Items.Add(r.ReadLine()); // svaki put kad se ucitaj jedan red doda se u listBox
            r.Close(); // na kraju rada OBAVEZNO zatvoriti vezu sa datotekom
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // kreira se veza sa datotekom podaci.txt za upisivanje podataka u datoteku
            FileStream fs =
                new FileStream("podaci.txt",//putanja
                    FileMode.Create,
                    FileAccess.Write);

            StreamWriter w = new StreamWriter(fs); // kreira se streamWriter nad ovom vezom


            foreach (string s in listBox1.Items) // foreach petlja za svaki string s iz nase liste
            {
                w.WriteLine(s); // upisuje se svaki red u datoteku
            }
            w.Close(); // na kraju rada se zatvara veza sa datotekom
            listBox1.Items.Clear(); // ocisti se listBox element od svih stavki
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                DodavanjeStavke();
            }
        }
    }
}
