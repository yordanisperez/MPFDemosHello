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

namespace WPFDemoToolsBar
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


        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            tbText.Text = "";
        }

        private void cbSizeFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)cbSender.SelectedItem;
            string strSize = (string)item.Content;
            int sizeFont;
            if (Int32.TryParse(strSize,out sizeFont))
            {
               if (tbText != null)
                {
                    tbText.FontSize = sizeFont;
                }
            }
        }
    }
}
