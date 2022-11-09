using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPF3_NZ
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = "";
            textblock_2.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "^";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "/";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "7";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "8";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "9";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "*";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "4";
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "5";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "6";
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "-";
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "1";
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "2";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "3";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "+";
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + ".";
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            textblock_1.Text = textblock_1.Text + "0";
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            textblock_2.Text = new DataTable().Compute(textblock_1.Text, null).ToString();
        }
    }
}
