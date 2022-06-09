using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for pageParking.xaml
    /// </summary>
    public partial class pageParking : Page
    {
        ParkingDbEntities context = new ParkingDbEntities();
        public ObservableCollection<parking> Parkings { get; set; } = new ObservableCollection<parking>();
        public pageParking()
        {
            var lista = context.parkings.ToList();
            foreach (var l in lista)
                Parkings.Add(l);
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = cb.SelectedItem as parking;
            TimeSpan razlika = DateTime.Now - selected.Vreme;
            Cenovnik cenovnik = context.Cenovniks.First();
            if(razlika.Hours >= 8)
            {
                MessageBox.Show($"Za naplatu {cenovnik.CeneDan}");
            }
            else
            {
                int sati = (razlika.Minutes == 0 && razlika.Seconds == 0) ? razlika.Hours : razlika.Hours + 1;
                MessageBox.Show($"Za naplatu {cenovnik.CeneSat*sati}");
            }
            await SnimanjeUBazi(selected);
        }
        private async Task SnimanjeUBazi(parking selected)
        {
            await Task.Run(() => {
                Thread.Sleep(10000);
                MessageBox.Show("Evo me posle 10 sekundi");
                }
            );
            context.parkings.Remove(selected);
            await context.SaveChangesAsync();
            Parkings.Remove(selected);
        }
    }
}
