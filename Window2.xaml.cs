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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarsRentalAgency
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

             

        private void Btn_Final_Click(object sender, RoutedEventArgs e)
        {
            Window3 WN = new Window3();
            WN.Show();
            this.Close();
        }

        private void Btn_rent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Tbx_Filter_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

}
