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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] number = new int[10];
        private string numberStr;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            txtBlckDisplay.Text = "";
        }

        private void BtnErase_Click(object sender, RoutedEventArgs e)
        {
            txtBlckDisplay.Text = "";
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            txtBlckDisplay.Text = "";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "1";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "2";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "3";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "4";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "5";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "6";
            txtBlckDisplay.Text = numberStr;
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "7";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "8";
            txtBlckDisplay.Text = numberStr;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "9";
            txtBlckDisplay.Text = numberStr;
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            txtBlckDisplay.Text =  "Evo ga " + numberStr;
        }
        
        
        // operatori
        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "/";
            txtBlckDisplay.Text = numberStr;
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "*";
            txtBlckDisplay.Text = numberStr;
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "-";
            txtBlckDisplay.Text = numberStr;
        }
        
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            numberStr = numberStr + "+";
            txtBlckDisplay.Text = numberStr;
        }
    }
}
