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

namespace XyrilleMamalateo.GPCONVERTER
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxGrade.Text == "98" || txtBoxGrade.Text == "99" || txtBoxGrade.Text == "100")
            {
                lblGP.Content = "1";
            }
            else if (txtBoxGrade.Text == "97" || txtBoxGrade.Text == "96" || txtBoxGrade.Text == "95")
            {
                lblGP.Content = "1.25";
            }
            else if (txtBoxGrade.Text == "92" || txtBoxGrade.Text == "93" || txtBoxGrade.Text == "94")
            {
                lblGP.Content = "1.5";
            }
            else if (txtBoxGrade.Text == "89" || txtBoxGrade.Text == "90" || txtBoxGrade.Text == "91")
            {
                lblGP.Content = "1.75";
            }
            else if (txtBoxGrade.Text == "86" || txtBoxGrade.Text == "87" || txtBoxGrade.Text == "88")
            {
                lblGP.Content = "2";
            }
            else if (txtBoxGrade.Text == "85" || txtBoxGrade.Text == "84" || txtBoxGrade.Text == "83")
            {
                lblGP.Content = "2.25";
            }
            else if (txtBoxGrade.Text == "82" || txtBoxGrade.Text == "81" || txtBoxGrade.Text == "80")
            {
                lblGP.Content = "2.5";
            }
            else if (txtBoxGrade.Text == "79" || txtBoxGrade.Text == "78" || txtBoxGrade.Text == "77" || txtBoxGrade.Text == "76")
            {
                lblGP.Content = "2.75";
            }
            else if (txtBoxGrade.Text == "75")
            {
                lblGP.Content = "3";
            }
            else if (txtBoxGrade.Text == "74" || txtBoxGrade.Text == "73")
            {
                lblGP.Content = "3.75";
            }
            else if (txtBoxGrade.Text == "72" || txtBoxGrade.Text == "71")
            {
                lblGP.Content = "3.5";
            }
            else if (txtBoxGrade.Text == "70" || txtBoxGrade.Text == "69")
            {
                lblGP.Content = "3.25";
            }
            else if (txtBoxGrade.Text == "68" || txtBoxGrade.Text == "67")
            {
                lblGP.Content = "4";
            }
            else if (txtBoxGrade.Text == "66" || txtBoxGrade.Text == "65")
            {
                lblGP.Content = "4.75";
            }
            else if (txtBoxGrade.Text == "64" || txtBoxGrade.Text == "63")
            {
                lblGP.Content = "4.5";
            }
            else if (txtBoxGrade.Text == "62" || txtBoxGrade.Text == "61")
            {
                lblGP.Content = "4.25";
            }
            else if (txtBoxGrade.Text == "60")
            {
                lblGP.Content = "5";
            }
        }
    }
}
