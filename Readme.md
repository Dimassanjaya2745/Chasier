# Cashier App
Aplikasi ini adalah aplikasi untuk manajemen barang, digunakan untuk menambahkan barang ke inventory

## Scope and Functionalities
* User dapat menginputkan huruf dan angka
* User dapat meng-klik tombol tambah
* User dapat melihat barang yang telah diinputkan pada ListBox
* User dapat melihat total harga 


## How Does it works?
Diawali dari method `MainWindow()` pada `class MainWindow.xaml.cs`, kita deklarasikan dan membuat instance
dari `Calculator` dan memasukkan list item ke ListBox yang didapat dari `calculator.getListItem()`

```csharp
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            ListBoxItem.ItemsSource = calculator.getListItem();
        }
```

Pada method `AddButton_Click_1()`, akan mendapatkan value yang diinputkan oleh user dan dimasukkan pada Data Class Item untuk diolah datanya.
Lalu akan dimasukkan kedalam sebuah objek `Calculator` . Pada class ini juga terdapat method `LitsBox.Items.Refresh()` untuk merefresk list box setelah item ditambahkan

```csharp
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
```


Prinsip penggunaan Single Reponsibility terdapat pada class `Calculator`. Pada class ini digunakan untuk menambahkan
item yang dimasukkan oleh user kedalam sebuah list dan menghitung total harganya
```csharp
        public void AddItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubtotal();
        }
```

Selain itu, class ini juga mengembalikan nilai dari masing - masing properti seperti pada method `getTotal()` dan `getListItem`