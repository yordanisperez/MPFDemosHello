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

namespace WPFDemoRadioButton
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

        private void rbObama_Checked(object sender, RoutedEventArgs e)
        {
            rbObama.Background = Brushes.Aqua;
        }

        private void rbObama_Unchecked(object sender, RoutedEventArgs e)
        {
            rbObama.Background = Brushes.White;
        }

        private void rbTrump_Checked(object sender, RoutedEventArgs e)
        {
            rbTrump.Background = Brushes.Aqua;
        }

        private void rbTrump_Unchecked(object sender, RoutedEventArgs e)
        {
            rbTrump.Background = Brushes.White;
        }

        private void rbMccain_Checked(object sender, RoutedEventArgs e)
        {
            rbMccain.Background = Brushes.Aqua;
        }

        private void rbMccain_Unchecked(object sender, RoutedEventArgs e)
        {
            rbMccain.Background = Brushes.White;
        }

        private void rbBiden_Checked(object sender, RoutedEventArgs e)
        {
            rbBiden.Background = Brushes.Aqua;
        }

        private void rbBiden_Unchecked(object sender, RoutedEventArgs e)
        {
            rbBiden.Background = Brushes.White;
        }
    }
}
