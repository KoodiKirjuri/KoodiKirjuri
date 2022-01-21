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

namespace Laskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero1 = 0;
        int numero2 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void painike1_Click(object sender, RoutedEventArgs e)
        {
            if (numero1 == 0)
            {
                numero1 = 1;
                tekstilaatikko.Text = "1";
            }
            else if (numero2 == 0)
            {
                numero2 = 1;
                tekstilaatikko.Text += " 1";
            }
        }

        private void painike2_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 2;
                tekstilaatikko.Text = "2";
            }
            else if(numero2 == 0) { numero2 = 2; tekstilaatikko.Text += " 2"; }
        }

        private void painike3_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 3;
                tekstilaatikko.Text = "3";
            }
            else if( numero2 == 0) { numero2 = 3; tekstilaatikko.Text += " 3"; }
        }

        private void painike4_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 4;
                tekstilaatikko.Text = "4";
            }
            else if(numero2 == 0) { numero2 = 4; tekstilaatikko.Text += " 4"; }
        }

        private void painike5_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 5;
                tekstilaatikko.Text = "5";
            }
            else if(numero2 == 0) { numero2 = 5; tekstilaatikko.Text += " 5"; }
        }

        private void painike6_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 6;
                tekstilaatikko.Text = "6";
            }
            else if(numero2 == 0) { numero2 = 6; tekstilaatikko.Text += " 6"; }
        }

        private void painike7_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 7;
                tekstilaatikko.Text = "7";
            }
            else if(numero2 == 0) { numero2 = 7; tekstilaatikko.Text += " 7"; }
        }

        private void painike8_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 8;
                tekstilaatikko.Text = "8";
            }
            else if (numero2 == 0) { numero2 = 8; tekstilaatikko.Text += " 8"; }
        }

        private void painike9_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 == 0)
            {
                numero1 = 9;
                tekstilaatikko.Text = "9";
            }
            else if( numero2 == 0) { numero2 = 9; tekstilaatikko.Text += " 9"; }
        }

        private void painikeplus_Click(object sender, RoutedEventArgs e)
        {
            tekstilaatikko.Text += " +";
        }

        private void painikemiinus_Click(object sender, RoutedEventArgs e)
        {
            tekstilaatikko.Text += " -";
        }

        private void painikekertaa_Click(object sender, RoutedEventArgs e)
        {
            tekstilaatikko.Text += " *";
        }

        private void painikekeno_Click(object sender, RoutedEventArgs e)
        {
            tekstilaatikko.Text += " /";
        }

        private void painikeyht_Click(object sender, RoutedEventArgs e)
        {
            if(numero1 != 0 && numero2 != 0)
            {
                var lopputulos = 0;
                var merkki = tekstilaatikko.Text.Substring(2,1);
                if (merkki == "+")
                {
                     lopputulos = numero1 + numero2;
                }
                else if(merkki == "-")
                {
                     lopputulos = numero1 - numero2;
                }
                else if(merkki == "*")
                {
                     lopputulos = numero1 * numero2;
                }
                else if(merkki == "/")
                {
                     lopputulos = numero1 / numero2;
                }
                tekstilaatikko.Text = lopputulos.ToString();
                numero1 = 0;
                numero2 = 0;
            }
        }

        private void painikeC_Click(object sender, RoutedEventArgs e)
        {
            tekstilaatikko.Text = "";
        }
    }
}
