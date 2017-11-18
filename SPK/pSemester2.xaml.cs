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
    /// Interaction logic for pSemester2.xaml
    /// </summary>
    public partial class pSemester2 : UserControl
    {
        public pSemester2()
        {
            InitializeComponent();
        }

        private void bTerus2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPBO.Text) == true || string.IsNullOrWhiteSpace(cbArsikom.Text) == true)
            {
                tblLarang.Visibility = Visibility.Visible;
            }

            else
            {
                Temper.semester = "3";
                Switcher.Switch(new ucSemester3());

                GlobalVariablesClass.Nilai[4] = cbPBO.SelectedIndex;
                GlobalVariablesClass.Nilai[5] = cbArsikom.SelectedIndex;
            }
        }

        private void cbPBO_GotFocus(object sender, RoutedEventArgs e)
        {
            cbPBO.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbPBO_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPBO.Text))
            {
                cbPBO.Opacity = 0;
            }
            else
                cbPBO.Opacity = 100;
        }

        private void cbArsikom_GotFocus(object sender, RoutedEventArgs e)
        {
            cbArsikom.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbArsikom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbArsikom.Text))
            {
                cbArsikom.Opacity = 0;
            }
            else
                cbArsikom.Opacity = 100;
        }
    }
}
