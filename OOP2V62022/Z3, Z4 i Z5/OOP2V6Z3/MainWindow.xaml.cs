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

namespace OOP2V6Z3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student Dalila = new Student { Ime = "Dalila", Prezime = "Pramenkovic", Prosek = 9.5f };
            Student Dzenis = new Student { Ime = "Dzenis", Prezime = "Hadzifejzovic", Prosek = 8.5f };
            Student Vahid = new Student { Ime = "Vahid", Prezime = "Uglic", Prosek = 10f };
            Student Ermin = new Student { Ime = "Ermin", Prezime = "Bronja", Prosek = 8 };
            StudijskiProgram SI = new StudijskiProgram { Naziv = "Softversko inzenjerstvo" };
            SI.Studenti.Add(Dalila);
            SI.Studenti.Add(Dzenis);
            SI.Studenti.Add(Vahid);
            SI.Studenti.Add(Ermin);
            Student Kamber = new Student { Ime = "Kamber", Prezime = "Kamberovic", Prosek = 9.5f };
            Student Amina = new Student { Ime = "Amina", Prezime = "Memic", Prosek = 8.5f };
            StudijskiProgram RT = new StudijskiProgram { Naziv = "Racunarska tehnika" };
            RT.Studenti.Add(Kamber);
            RT.Studenti.Add(Amina);
            var StudijskiProgrami = new List<StudijskiProgram>();
            StudijskiProgrami.Add(SI);
            StudijskiProgrami.Add(RT);
            
            trvDUNP.ItemsSource = StudijskiProgrami;
        }
    }
}
