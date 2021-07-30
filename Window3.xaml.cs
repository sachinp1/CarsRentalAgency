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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Btn_Print_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "Print Invoice");
                }
            }

            finally
            {
                this.IsEnabled = true;
            }
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
        
        private void Btn_rent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
