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

namespace WpfLR5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush backgr;
        Brush foregr;
        public MainWindow()
        {
            InitializeComponent();
            backgr = textBox1.Background;
            foregr = textBox2.Foreground;
            textBox1.Focus();
        }

        private void textBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            tb.Foreground = Brushes.White;
            tb.Background = Brushes.Green;
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            tb.Foreground = foregr;
            tb.Background = backgr;
        }
    }
}

