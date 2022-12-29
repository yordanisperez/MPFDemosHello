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

namespace WPFCheckboxDemo
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

        private void changeChildrenPizza(object sender, RoutedEventArgs e)
        {
            CheckBox childrenCheck= (CheckBox) sender;
            bool newValue = (childrenCheck.IsChecked == true);

            if (childrenCheck==cbCheese )
            {
                if (newValue)
                    lbCheese.Background = Brushes.Gray;
                else
                    lbCheese.Background = Brushes.White;
            }
            if (childrenCheck == cbPepperoni)
            {
                if (newValue)
                    lbPepperoni.Background = Brushes.Gray;
                else
                    lbPepperoni.Background = Brushes.White;
            }

            if (childrenCheck == cbHam)
            {
                if (newValue)
                    lbHam.Background = Brushes.Gray;
                else
                    lbHam.Background = Brushes.White;
            }

            if (childrenCheck == cbTuna)
            {
                if (newValue)
                    lbTuna.Background = Brushes.Gray;
                else
                    lbTuna.Background = Brushes.White;
            }

            if (cbTuna.IsChecked==true && cbCheese.IsChecked==true && cbPepperoni.IsChecked==true && cbHam.IsChecked==true)
            {
                cbAllPizza.IsChecked = true;
                return;
            }

            if (cbTuna.IsChecked == false && cbCheese.IsChecked == false && cbPepperoni.IsChecked == false && cbHam.IsChecked == false)
            {
                cbAllPizza.IsChecked = false;
                return;
            }

            cbAllPizza.IsChecked = null;
        }

        private void cbAllPizza_change(object sender, RoutedEventArgs e)
        {
            bool newValue = (cbAllPizza.IsChecked == true);
            if (cbAllPizza.IsChecked == null)
            {
                cbAllPizza.IsChecked = false;
                return;
            }
            cbCheese.IsChecked = newValue;
            cbHam.IsChecked = newValue;
            cbPepperoni.IsChecked = newValue;
            cbTuna.IsChecked = newValue;
        }
    }
}
