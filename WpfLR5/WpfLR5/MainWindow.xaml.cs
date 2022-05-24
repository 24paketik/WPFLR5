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

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var el in grid1.Children)
            {
                TextBox tb = el as TextBox;
                if (tb != null)
                    tb.TabIndex = int.MaxValue;
            }
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            for (int i =0; i < grid1.Children.Count - 1; i++)
            {
                TextBox tb = grid1.Children[i] as TextBox;
                tb.TabIndex = i * (int)Math.Pow(10, i % 3);
            }
        }
    }
}

