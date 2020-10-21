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

namespace Cashier_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            ListBoxItem.ItemsSource = calculator.getListItem();
        }

        private void AddButton_Click_1(object sender, RoutedEventArgs e)
        {
            string title = NameBox.Text;
            int jumlah = Convert.ToInt32(QuantityBox.Text);
            string type = TypeComboBox.Text;
            double price = Convert.ToDouble(PriceBox.Text);

            Item item = new Item(new Random().Next(), title, jumlah, type, price);
            calculator.AddItem(item);
            double total = calculator.getTotal();

            TotalBox.Content = String.Format("RP. {0}", total);

            ListBoxItem.Items.Refresh();
        }

        private void TipeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
