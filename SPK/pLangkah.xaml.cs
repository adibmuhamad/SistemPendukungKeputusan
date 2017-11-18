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
    /// Interaction logic for pLangkah.xaml
    /// </summary>
    public partial class pLangkah : UserControl
    {
        public pLangkah()
        {
            InitializeComponent();
            if (Temper.semester == "1")
            {
                tblSem1.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (Temper.semester == "2")
            {
                tblSem1.Foreground = new SolidColorBrush(Colors.White);
                tblSem2.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (Temper.semester == "3")
            {
                tblSem2.Foreground = new SolidColorBrush(Colors.White);
                tblSem3.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (Temper.semester == "4")
            {
                tblSem3.Foreground = new SolidColorBrush(Colors.White);
                tblSem4.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (Temper.semester == "5")
            {
                tblSem4.Foreground = new SolidColorBrush(Colors.White);
                tblHasil.Foreground = new SolidColorBrush(Colors.Yellow);
            }
        }
    }
}
