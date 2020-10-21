# Chasier App
Cashier helps storeowners record sales &amp; purchases seamlessly. Manage inventory by scanning product's barcode &amp; keep track of your stock based on daily

# Functionalities
User can inputing alpabhet and numbers
User can clicking add button
User can see goods on Listbox
User can see amount price

# How Does It works?
method MainWindow() on class MainWindow.xaml.cs, 
we declare and create an instance of Calculator and insert a list item into the ListBox obtained from calculator.getListItem()

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            ListBoxItem.ItemsSource = calculator.getListItem();
        }
On method AddButton_Click_1(), will get the value entered by the user and entered in the Data Class Item for data processing. Then it will be entered into a Calculator object. 
This class also exists method LitsBox.Items.Refresh() to refresh the list box after the item is added

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
The principle of using Single Responsibility is in the Calculator class. This class is used to add items entered by the user to a list and calculate the total price

        public void AddItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubtotal();
        }

Apart from that, this class also returns the value of each property as in the getTotal () and getListItem methods
