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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            String s = "";
            if(txtName.Text.Equals(String.Empty) || txtName.Text.Length < 2)
            {
                MessageBox.Show("Entered user should contain at least 2 symbols!");   
            }
            else
            {
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        s = s + ((TextBox)item).Text;
                        s = s + '\n';
                    }
                }
                MessageBox.Show("Hello \n" + s + "!!!\nThis is your first program on Visual Studio 2017!");
            }
           
        }*/

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Windows Presentation Foundation!");
            textBlock1.Text = DateTime.Now.ToString();
        }
    }
}
