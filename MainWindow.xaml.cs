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
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Windows.Media.Animation;


namespace CarsRentalAgency
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //App._customers = CreateCustomerData(20);
            Lbx_Customer.ItemsSource = App._customers;
        }

        //private ObservableCollection<Customer> CreateCustomerData(int cnt)
        //{
        //    var ObservableCollection = new ObservableCollection<Customer>();

        //    for (int i = 0; i < cnt; i++) // 2 times tab to get for loop
        //    {
        //        ObservableCollection.Add(new Customer { nameFirst = $"Shyam{i}", nameLast = $"Lakhani{i}" });
        //    }
        //    return ObservableCollection;
        //}


        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var std = Lbx_Customer.SelectedItem as Customer;
            if (std == null)
            {
                MessageBox.Show("Plese select Customer first to be deleted", "Hint");
                return;
            }
            App._customers.Remove(std);
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var std = new Customer { nameFirst = "Add firstname", nameLast = "Add lastname", };
            App._customers.Add(std);
            Lbx_Customer.ScrollIntoView(std);
            Lbx_Customer.SelectedItem = std;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tbx_Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (App._customers == null) return;
            var filter = (sender as TextBox).Text.ToLower();
            if (filter == null) return;
            var result = from c in App._customers where c.nameFirst.ToLower().Contains(filter) select c;
            Lbx_Customer.ItemsSource = result;
        }

        DoubleAnimation da = new DoubleAnimation(20, TimeSpan.FromSeconds(1.5));
        private void Grd_Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            da.To = 150;
            Grd_Menu.BeginAnimation(Grid.WidthProperty, da);
        }

        private void Grd_Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            da.To = 20;
            Grd_Menu.BeginAnimation(Grid.WidthProperty, da);
        }

        private void Btn_next_1(object sender, RoutedEventArgs e)
        {
            Window2 WN = new Window2();
            WN.Show();
            this.Close();
        }
    }
}

    

