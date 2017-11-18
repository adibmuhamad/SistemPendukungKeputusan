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
    /// Interaction logic for pHasil.xaml
    /// </summary>
    public partial class pHasil : UserControl
    {
        public pHasil()
        {
            InitializeComponent();

            SAWMethod.SAW();
            
            if (((GlobalVariablesClass.V[0] > GlobalVariablesClass.V[1]) && (GlobalVariablesClass.V[0] > GlobalVariablesClass.V[2])) && GlobalVariablesClass.V[1] > GlobalVariablesClass.V[2])
            {
                    tblHasil.Text += "RSI";
                    tblHasil2.Text += "RPL";
                    tblHasil3.Text += "RSK";
            }else if (((GlobalVariablesClass.V[0] > GlobalVariablesClass.V[1]) && (GlobalVariablesClass.V[0] > GlobalVariablesClass.V[2])) && GlobalVariablesClass.V[2] > GlobalVariablesClass.V[1])
            {
                    tblHasil.Text += "RSI";
                    tblHasil2.Text += "RSK";
                    tblHasil3.Text += "RPL";
             }
            

            else if(((GlobalVariablesClass.V[1] > GlobalVariablesClass.V[0]) && (GlobalVariablesClass.V[1] > GlobalVariablesClass.V[2])) && GlobalVariablesClass.V[0] > GlobalVariablesClass.V[2])
            {
               tblHasil.Text += "RPL";
               tblHasil2.Text += "RSI";
               tblHasil3.Text += "RSK";
            }
            else if (((GlobalVariablesClass.V[1] > GlobalVariablesClass.V[0]) && (GlobalVariablesClass.V[1] > GlobalVariablesClass.V[2])) && GlobalVariablesClass.V[2] > GlobalVariablesClass.V[0])
            {
                    tblHasil.Text += "RPL";
                    tblHasil2.Text += "RSK";
                    tblHasil3.Text += "RSI";
                
            }

            else if (((GlobalVariablesClass.V[2] > GlobalVariablesClass.V[1]) && (GlobalVariablesClass.V[2] > GlobalVariablesClass.V[0])) && GlobalVariablesClass.V[0] > GlobalVariablesClass.V[1])
            {
               tblHasil.Text += "RSK";
               tblHasil2.Text += "RSI";
               tblHasil3.Text += "RPL";
            }
            else if (((GlobalVariablesClass.V[2] > GlobalVariablesClass.V[1]) && (GlobalVariablesClass.V[2] > GlobalVariablesClass.V[0])) && GlobalVariablesClass.V[1] > GlobalVariablesClass.V[0])
            {
                    tblHasil.Text += "RSK";
                    tblHasil2.Text += "RPL";
                    tblHasil3.Text += "RSI";
                
            }
            else
            {
                tblHasil.Text += "Anda Cocok di Air";
            }
        }

        private void bRestart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            window2.Show();

            var myWindow = Window.GetWindow(this);
            myWindow.Close();
            for(int keluar = 0; keluar < 3; keluar++)
            {
                GlobalVariablesClass.V[keluar] = 0;
            }
        }
    }
}
