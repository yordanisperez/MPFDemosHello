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

namespace WPFDemoSlider
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

        private void slMyslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (tbValueSlider!=null /*&& slMyslider.Value > 0d*/)
            {
                tbValueSlider.Text = "Value slider es " + slMyslider.Value.ToString();
               // tbValueSlider.FontSize = slMyslider.Value;
            }
               
        }
    }
}
