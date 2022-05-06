using System;
using System.Collections.Generic;
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

namespace OOP2v3z1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            // konstruktor
            InitializeComponent();
            cbBoja.Items.Add("crveno");
            cbBoja.Items.Add("plavo");
            cbBoja.Items.Add("zeleno");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // dogadjaj kada se forma loaduje odnosno ucita
            // dogadjaj koji se veoma cesto koristi
            txtDogadjaji.Text += "Prozor se učitao";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // dogadjaj kada je prozor u procesu zatvaranja. Dakle jos uvek se nije zatvorio ali pokusava
            // proverava se da li je dozvoljeno zatvaranje 
            txtDogadjaji.Text += "Prozor se zatvara";
            if (rbNijeDozvoljeno.IsChecked == true)
                e.Cancel = true;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // dogadjaj za klikom misa na prozor
            txtDogadjaji.Text += "Mouse Click";
        }

        private void cbBoja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // dogadjaj za promenu vrednosti u comboBox-u za izbor boje
            string selItem = (string)cbBoja.SelectedItem;
            txtDogadjaji.Text += selItem + Environment.NewLine;//"\r\n";
            // moze se proveriti pomocu if naredbi
            //if ("crveno" == selItem)
            //    Background = Brushes.Red;
            //else if("plavo" == selItem)
            //    this.Background = Brushes.Blue;
            //else if ("zeleno" == selItem)
            //    Background = Brushes.Green;
            // ili bolje resenje moze se proveriti pomocu switch naredbe
            // dodatak u C# jeste sto u switch mozete koristiti i varijable tipa string
            switch (selItem)
            {
                case "crveno": Background = Brushes.Red; break;
                case "zeleno": Background = Brushes.Green; break;
                case "plavo": Background = Brushes.Blue; break;
                default: Background = Brushes.White; break;
            }
        }

        private void rbDozvoljeno_Checked(object sender, RoutedEventArgs e)
        {
            // zajednicki dogadjaj za radioButton elemente
            // treba proveriti koji je, od ponudjena dva, cekiran
            RadioButton rb = (RadioButton)sender;
            txtDogadjaji.Text += Environment.NewLine;
            if (rb.Name == "rbDozvoljeno")
            {
                txtDogadjaji.Text += "rbDozvoljeno="
                    + rb.IsChecked + Environment.NewLine;
            }
            else if (rb.Name == "rbNijeDozvoljeno")
            {
                txtDogadjaji.Text += "rbNijeDozvoljeno="
                    + rb.IsChecked + Environment.NewLine; ;
            }
        }

        private void izlaz_Click(object sender, RoutedEventArgs e)
        {
            // dogadjaj klikom na dugme za zatvanje aplikacije
            this.Close();
        }
    }
}
