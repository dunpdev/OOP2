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

namespace Zadatak2
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
            set { _rows = value;
                PodesiDugmice();
            }
        }

        public int Cols
        {
            get { return _cols; }
            set { _cols = value;
                PodesiDugmice();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            dugmici = new Button[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    dugmici[i, j] = new Button();
                    podloga.Children.Add(dugmici[i, j]);
                }
            _rows = 8;
            Cols = 3;
        }
        private void PodesiDugmice()
        {
            float sirina = 800 / _cols;
            float visina = 420 / _rows;
            for(int i=0;i<10;i++)
                for(int j=0;j<10;j++)
                {
                    if(i < _rows && j < _cols)
                    {
                        // PODESI DUGME
                        dugmici[i, j].Width = sirina;
                        dugmici[i, j].Height = visina;
                        dugmici[i, j].Background = Brushes.Red;
                        dugmici[i, j].Content = $"{i} , {j}";
                        dugmici[i, j].Visibility = Visibility.Visible;
                        Canvas.SetLeft(dugmici[i, j], sirina * j);
                        Canvas.SetTop(dugmici[i, j], visina * i);
                    }
                    else
                    {
                        dugmici[i, j].Visibility = Visibility.Hidden;
                    }
                }
        }
        
    }
}
