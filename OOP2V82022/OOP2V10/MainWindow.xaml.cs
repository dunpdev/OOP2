using OOP2V10.View;
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

namespace OOP2V10
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            pageCenovnik p = new pageCenovnik();
            main.Content = p;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            pageVlasnici p = new pageVlasnici();
            main.Content = p;
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            pageParking p = new pageParking();
            main.Content = p;
        }
    }
}
