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

namespace Zadatak3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _cols;
        private int _rows;
        private Button[,] dugmici;
        public int Rows
        {
            get { return _rows; }
            set
            {
                _rows = value;
                PodesiDugmice();
            }
        }

        public int Cols
        {
            get { return _cols; }
            set
            {
                _cols = value;
                PodesiDugmice();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            dugmici = new Button[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    dugmici[i, j] = new Button();
                    podloga.Children.Add(dugmici[i, j]);
                    dugmici[i, j].Click += KlikDogadjaj;
                }
            _rows = 8;
            Cols = 8;
        }

        private void KlikDogadjaj(object sender, RoutedEventArgs e)
        {
            Button currentButton = (Button)sender;
            MessageBox.Show($"Kliknuli ste na polje {currentButton.Content}");
        }

        private void PodesiDugmice()
        {
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                {
                    // PODESI DUGME
                    //dugmici[i, j].Width = sirina;
                    //dugmici[i, j].Height = visina;
                    if (i % 2 != 0 && j % 2 == 0 || i % 2 == 0 && j % 2 != 0)
                        dugmici[i, j].Background = Brushes.Silver;
                    else
                        dugmici[i, j].Background = Brushes.White;
                    dugmici[i, j].Content = $"{(char)(72-i)}{j+1}"; // H1, H2, H3 ... H8, ... A1, A2, ... A8
                    Grid.SetRow(dugmici[i, j], i);
                    Grid.SetColumn(dugmici[i, j], j);
                }
        }

    }
}
