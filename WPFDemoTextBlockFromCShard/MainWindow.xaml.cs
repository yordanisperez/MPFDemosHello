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

namespace WPFDemoTextBlockFromCShard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbHello.Text = "Hello from file cs";
            tbHello.Foreground = Brushes.Blue;
            tbHello.Inlines.Add("I am using inlines");
            tbHello.Inlines.Add(new Run("Run text that I added in code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations= TextDecorations.Underline,
            });
            tbHello.TextWrapping = TextWrapping.Wrap;
        }
    }
}
