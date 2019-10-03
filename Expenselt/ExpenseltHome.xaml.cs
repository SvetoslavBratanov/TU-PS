using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseltHome.xaml
    /// </summary>
    public partial class ExpenseltHome : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastChecked"));
            }
        }
        public ObservableCollection<string> PersonsChecked { get; set; }


        public ExpenseltHome()
        {
            InitializeComponent();
            LastChecked = DateTime.Now;
            DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value;
            MessageBox.Show("Hi " + greetingMsg);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            //this.NavigationService.Navigate(expenseReportPage);
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);

        }
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value);
        }

    }
}
