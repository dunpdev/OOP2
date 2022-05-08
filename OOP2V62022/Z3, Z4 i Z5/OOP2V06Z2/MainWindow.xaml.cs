using System.Windows;

namespace OOP2V06Z2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Stavka root = new Stavka { Naziv = "Porodicno stablo" };
            Stavka d1 = new Stavka { Naziv = "Dedo" };
            Stavka b1 = new Stavka { Naziv = "Babo" };
            Stavka j1 = new Stavka { Naziv = "Ja" };
            Stavka j2 = new Stavka { Naziv = "Brat" };
            Stavka j3 = new Stavka { Naziv = "Sestra" };
            b1.PodStavke.Add(j1);
            b1.PodStavke.Add(j2);
            b1.PodStavke.Add(j3);
            Stavka b2 = new Stavka { Naziv = "Babov brat" };
            Stavka b3 = new Stavka { Naziv = "Babov drugi brat" };
            d1.PodStavke.Add(b1);
            d1.PodStavke.Add(b2);
            d1.PodStavke.Add(b3);
            Stavka d2 = new Stavka { Naziv = "Dedov brat" };
            root.PodStavke.Add(d1);
            root.PodStavke.Add(d2);

            trvStavke.Items.Add(root);
        }
    }
}
