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
    /// Interaction logic for pSemester4.xaml
    /// </summary>
    public partial class pSemester4 : UserControl
    {
        public pSemester4()
        {
            InitializeComponent();
        }

        private void cbTVG_GotFocus(object sender, RoutedEventArgs e)
        {
            cbTVG.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbTVG_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTVG.Text))
            {
                cbTVG.Opacity = 0;
            }
            else
                cbTVG.Opacity = 100;
        }

        private void cbTekdig_GotFocus(object sender, RoutedEventArgs e)
        {
            cbTekdig.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbTekdig_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTekdig.Text))
            {
                cbTekdig.Opacity = 0;
            }
            else
                cbTekdig.Opacity = 100;
        }

        private void cbCerbut_GotFocus(object sender, RoutedEventArgs e)
        {
            cbCerbut.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbCerbut_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCerbut.Text))
            {
                cbCerbut.Opacity = 0;
            }
            else
                cbCerbut.Opacity = 100;
        }

        private void cbAPL_GotFocus(object sender, RoutedEventArgs e)
        {
            cbAPL.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbAPL_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAPL.Text))
            {
                cbAPL.Opacity = 0;
            }
            else
                cbAPL.Opacity = 100;
        }

        private void cbRPL_GotFocus(object sender, RoutedEventArgs e)
        {
            cbRPL.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbRPL_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbRPL.Text))
            {
                cbRPL.Opacity = 0;
            }
            else
                cbRPL.Opacity = 100;
        }

        private void cbIMK_GotFocus(object sender, RoutedEventArgs e)
        {
            cbIMK.Opacity = 100;
            tblLarang.Visibility = Visibility.Hidden;
        }

        private void cbIMK_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbIMK.Text))
            {
                cbIMK.Opacity = 0;
            }
            else
                cbIMK.Opacity = 100;
        }

        private void bTerus4_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTVG.Text) == true || string.IsNullOrWhiteSpace(cbTekdig.Text) == true || string.IsNullOrWhiteSpace(cbCerbut.Text) == true || string.IsNullOrWhiteSpace(cbAPL.Text) == true || string.IsNullOrWhiteSpace(cbRPL.Text) == true || string.IsNullOrWhiteSpace(cbIMK.Text) == true)
            {
                tblLarang.Visibility = Visibility.Visible;
            }

            else
            {
                Temper.semester = "5";

                GlobalVariablesClass.Nilai[11] = cbTVG.SelectedIndex;
                GlobalVariablesClass.Nilai[12] = cbTekdig.SelectedIndex;
                GlobalVariablesClass.Nilai[13] = cbCerbut.SelectedIndex;
                GlobalVariablesClass.Nilai[14] = cbAPL.SelectedIndex;
                GlobalVariablesClass.Nilai[15] = cbRPL.SelectedIndex;
                GlobalVariablesClass.Nilai[16] = cbIMK.SelectedIndex;

                Switcher.Switch(new ucHasil());
            }
        }
    }
}
