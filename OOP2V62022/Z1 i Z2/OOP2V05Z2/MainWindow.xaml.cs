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

namespace OOP2V05Z2
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

        private void txtZaComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string stavka = txtZaComboBox.Text;
                string val = stavka.Trim();
                if (string.IsNullOrEmpty(val))
                {
                    MessageBox.Show("Vas string je prazan");
                }
                else
                {
                    if (cbStavke.Items.Contains(val))
                        MessageBox.Show($"Uneta stavka {val} se vec nalazi u combo box-u");
                    else
                    {
                        cbStavke.Items.Add(val);
                        txtZaComboBox.Text = string.Empty;
                        txtBrojRedovaComboBox.Text = cbStavke.Items.Count.ToString();
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream(
                "podaciZaComboBox.txt",
                FileMode.Create,
                FileAccess.Write
                );
            StreamWriter sw = new StreamWriter(fs);
            foreach(var s in cbStavke.Items)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            MessageBox.Show("Uspesno snimanje");
            cbStavke.Items.Clear();
        }
        private void Ucitaj_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream(
                "podaciZaComboBox.txt",
                FileMode.Open,
                FileAccess.Read
                );
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
                cbStavke.Items.Add(sr.ReadLine());
            sr.Close();
        }

        private void cbStavke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string izabranaStavka = cb.SelectedItem as string;
            txtIzabranaStavkaComboBox.Text = izabranaStavka;
        }


        // list Box
        private void txtZaListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string stavka = txtZaListBox.Text;
                string val = stavka.Trim();
                if (string.IsNullOrEmpty(val))
                {
                    MessageBox.Show("Vas string je prazan");
                }
                else
                {
                    if (lbStavke.Items.Contains(val))
                        MessageBox.Show($"Uneta stavka {val} se vec nalazi u list box-u");
                    else
                    {
                        lbStavke.Items.Add(val);
                        txtZaListBox.Text = string.Empty;
                        txtBrojRedovaListBox.Text = lbStavke.Items.Count.ToString();
                    }
                }
            }
        }

        private void SnimanjeListBox_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream(
                "podaciZaListBox.txt",
                FileMode.Create,
                FileAccess.Write
                );
            StreamWriter sw = new StreamWriter(fs);
            foreach (var s in lbStavke.Items)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            MessageBox.Show("Uspesno snimanje");
            lbStavke.Items.Clear();
        }
        private void UcitajListBox_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream(
                "podaciZaListBox.txt",
                FileMode.Open,
                FileAccess.Read
                );
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
                lbStavke.Items.Add(sr.ReadLine());
            txtBrojRedovaListBox.Text = lbStavke.Items.Count.ToString();
            sr.Close();
        }

        private void lbStavke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox cb = (ListBox)sender;
            string izabranaStavka = cb.SelectedItem as string;
            txtIzabranaStavkaListBox.Text = izabranaStavka;
        }
    }
}
