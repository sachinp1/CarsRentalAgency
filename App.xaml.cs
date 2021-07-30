using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarsRentalAgency
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<Customer> _customers;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //_customers = My_Storage.ReadXml("Customers.xml");
            _customers = My_Storage.ReadXml<ObservableCollection<Customer>>("Customers.xml");
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            //My_Storage.WriteXml(cust, "Customer.xml");
            //var cust = new List<Customer> { new Customer { nameFirst = "Harshad", nameLast = "Patel", dateBirth = "13/07/1995",
            //    nationality = "Indian", proofOfID = "Passport", iDNo = 4572385, mobileNo = 01765982459, appNo = 37, Street = "Am Steingarten",
            //    City = "Mannheim", Pincode = 68159 },
            //    new Customer { nameFirst = "Parimal", nameLast = "Patel", dateBirth = "14/09/1689",
            //    nationality = "Indian", proofOfID = "Passport", iDNo = 5873211, mobileNo = 01762875488, appNo = 35, Street = "Nuemann 9",
            //    City = "Mannheim", Pincode = 68156 }, new Customer { nameFirst = "Harshad", nameLast = "Patel", dateBirth = "23/10/1988",
            //    nationality = "Indian", proofOfID = "Passport", iDNo = 4572385, mobileNo = 01765982459, appNo = 37, Street = "Am Steingarten",
            //    City = "Mannheim", Pincode = 68169 } };
            My_Storage.WriteXml(App._customers, "Customers.Xml");
        }
    }
}


