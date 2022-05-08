using System.Diagnostics;
using System.IO;
using System.Windows;

namespace OOP2V06Z1
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
        private void lbFolderi_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                string putanja = txtZaPretragu.Text + "\\" + (lbFolderi.SelectedItem as string);
                DirectoryInfo di = new DirectoryInfo(putanja);
                lbFajlovi.Items.Clear();
                foreach (var f in di.GetFiles())
                {
                    lbFajlovi.Items.Add(f.Name);
                }
            }
            catch
            {

            }
        }
        private void lbFajlovi_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (lbFajlovi.SelectedIndex > -1)
            {
                string putanja = txtZaPretragu.Text + "\\" + (lbFolderi.SelectedItem as string) + "\\" + (lbFajlovi.SelectedItem as string);
                Process.Start(putanja);
            }
            else
            {
                MessageBox.Show("Niste izabrali odgovarajuci fajl");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PretragaPoPutanji();
        }
        private void lbFolderi_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            txtZaPretragu.Text += "\\" + (lbFolderi.SelectedItem as string);
            PretragaPoPutanji();
        }
        private void PretragaPoPutanji()
        {
            string putanja = txtZaPretragu.Text;
            DirectoryInfo di = new DirectoryInfo(putanja);
            lbFolderi.Items.Clear();
            foreach (var a in di.GetDirectories())
            {
                lbFolderi.Items.Add(a.Name);
            }
        }
    }
}
