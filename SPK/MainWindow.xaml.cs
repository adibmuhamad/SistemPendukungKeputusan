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

namespace SPK
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

        private void tbNama_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) == true)
            {
                tblNama.Visibility = Visibility.Visible;
            }
            else
                tblNama.Visibility = Visibility.Hidden;
        }

        private void tbNIM_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) == true)
            {
                tblNIM.Visibility = Visibility.Visible;
            }
            else
                tblNIM.Visibility = Visibility.Hidden;
        }

        private void tbNama_GotFocus(object sender, RoutedEventArgs e)
        {
            tblNama.Visibility = Visibility.Hidden;
        }

        private void tbNIM_GotFocus(object sender, RoutedEventArgs e)
        {    
            tblNIM.Visibility = Visibility.Hidden;
        }

        private void bMasuk_Click(object sender, RoutedEventArgs e)
        {
            InputWindow mainwindow = new InputWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
