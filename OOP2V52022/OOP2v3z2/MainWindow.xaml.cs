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

namespace OOP2v3z2
{
    public class opstina
    {
        public int broj { get; set; }
        public string naziv { get; set; }
        public int brstan { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<opstina> opstine = new List<opstina>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IzracunajProsek() // metoda koja racuna prosek stanovnistva 
        {
            int i = 0; // brojacka promenlijva za for petlju
            int brojac = 0; // brojac koliko ima gradova da bi se na kraju izracunao prosek kao suma / taj broj gradova
            int zbir = 0; // suma stanovnistva za svaki grad
            for (i = 0; i < listaOpstina.Items.Count; i++) // for petlja gde i ide od 0 do broja koliko ima opstina u listView-u
            {
                zbir = zbir + (listaOpstina.Items[i] as opstina).brstan; // na zbir dodaje vrednost 3. kolone iz svakog reda listView-a. Vrednost u listView-u je string pa se zato parsira u int koriscenjem int.Parse()
                brojac++; // uvecava brojac za 1
            }
            if (brojac != 0) // proverava se da li ima bar jedan grad tj da je brojac != 0 ili se moze napisati brojac > 0
            {
                float prosek = (float)zbir / brojac; // prosek se racuna kao zbir / broj gradova
                pbs.Text = prosek.ToString("0.00"); // rezultat se mesta u textBox txtProsek, funkcija ToString sa formatom ("0.00") zaokruzice taj broj na 2 decimale
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string posbroj = pb.Text; // uzima se vrednost za postanski broj iz textBoxa
            string naziv = no.Text;// uzima se vrednost za naziv iz textBoxa
            string broj = bs.Text;// uzima se vrednost za broj stanovnika iz textBoxa

            if (string.IsNullOrWhiteSpace(posbroj) || string.IsNullOrWhiteSpace(naziv) || string.IsNullOrWhiteSpace(broj)) // proverava ako ima neki od textboxoa da je null vrednost ili da su upisani samo razmaci
            {
                if (string.IsNullOrWhiteSpace(posbroj)) // ako je to slucaj za posbroj
                    MessageBox.Show("Uneti POSTANSKI BROJ!"); // ispisuje se poruke
                if (string.IsNullOrWhiteSpace(naziv))// ako je za naziv
                    MessageBox.Show("Uneti NAZIV OPSTINE!"); // ispisuje se poruka
                if (string.IsNullOrWhiteSpace(broj)) // ako je za broj
                    MessageBox.Show("Uneti BROJ STANOVNIKA!"); // ispisuje se poruka
            }
            else // u suprotnom znaci da su upisane vrednosti
            {
                //string provPB = pb.Text.Trim(); // u proverenu promenljivu provPB smesta se tekst iz textboxa ali se poziva trim da ukloni razmake s pocetka i kraja
                //ListViewItem ProveraPB = listaOpstina.(provPB); //proverava da li moze da nadje takav postanski broj u listView-u 
                //string provNM = no.Text.Trim(); // isto radi za ime
                //ListViewItem ProveraNM = listaOpstina.FindItemWithText(provNM);
                //if (ProveraPB == null && ProveraNM == null) // proverava da li je nasao da se vec pojavio postanski broj ili ime
                //{ // ako nije nasao da se pojavljuju onda unosi novi red u listView
                //    var red = new string[] { posbroj, naziv, broj };
                //    var red1 = new ListViewItem(red);
                //    listaOpstina.Items.Add(red1);
                //    IzracunajProsek(); // racuna novi prosek
                //}
                //else
                //{ // ako je nasao onda ispisuje poruke sta od unetih vrednosti vec posotji ime ili postanski broj
                //    if (ProveraPB != null)
                //        MessageBox.Show("POSTANSKI BROJ JE VEC UNET!");
                //    if (ProveraNM != null)
                //        MessageBox.Show("POSTANSKI MESTA JE VEC UNET!");
                //}
                opstina o = new opstina();
                o.broj = int.Parse(pb.Text);
                o.naziv = no.Text;
                o.brstan = int.Parse(bs.Text);
                opstine.Add(o);
                listaOpstina.ItemsSource = null;
                listaOpstina.ItemsSource = opstine;
                IzracunajProsek();

                pb.Text = string.Empty; // brise sadrzaj iz textBox-ova da korisnik unosi opet
                no.Text = string.Empty;
                bs.Text = string.Empty;
            }

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int index = listaOpstina.SelectedIndex;
            if (listaOpstina.Items.Count > 0 && index > -1)
            {
                cmdDa.Visibility = Visibility.Visible; // prikazuje se dugme cmdDa, pre je bilo sakriveno
                cmdNe.Visibility = Visibility.Visible; // prikazuje se dugme cmdNe, pre je bilo sakriveno
            }
            else if (listaOpstina.Items.Count == 0) // proverava ako je broj redova u listi 0 znaci da nema opstina
                MessageBox.Show("Nista nije uneto!"); // ispisuje se poruka da nema opstina pomocu iskacuceg prozora
            else 
                MessageBox.Show("Niste izabrali opštinu");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) // proverava da li je dugme koje je pritisnuto escape
            {
                Button_Click(sender, e); // ako jeste pokrece dogadjaj cmdIzlaz koja ce ugasiti program
            }
        }

        private void cmdDa_Click(object sender, RoutedEventArgs e)
        {
            int index = listaOpstina.SelectedIndex;
            if (index > -1)
            {
                var opstinaZaBrisanje = listaOpstina.Items[index] as opstina;
                opstine.Remove(opstinaZaBrisanje);
                listaOpstina.ItemsSource = null;
                listaOpstina.ItemsSource = opstine;
                IzracunajProsek();
            }
            else
                MessageBox.Show("Niste izabrali opštinu");
            cmdDa.Visibility = Visibility.Hidden; // krije se dugme cmdDa, pre je bilo vidljivo
            cmdNe.Visibility = Visibility.Hidden; // krije se dugme cmdNe, pre je bilo vidljivo
        }

        private void cmdNe_Click(object sender, RoutedEventArgs e)
        {
            cmdDa.Visibility = Visibility.Hidden; // krije se dugme cmdDa, pre je bilo vidljivo
            cmdNe.Visibility = Visibility.Hidden; // krije se dugme cmdNe, pre je bilo vidljivo
        }
    }
}
