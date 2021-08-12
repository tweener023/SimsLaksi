using Controller;
using Model;
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
using System.Windows.Shapes;

namespace Project.View
{
    /// <summary>
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {

        ReceiptController receiptController = new ReceiptController();


        private List<Medicine> itemsToShow = new List<Medicine>();
        private Receipt order;


        public Checkout(List<Medicine> toShow)
        {
            InitializeComponent();

            itemsToShow = toShow;
            cartDataGrid.ItemsSource = itemsToShow;
        }

        private void onOrder(object sender, RoutedEventArgs e)
        {
            // dodaj da pokupi date and time

            Dictionary<string, int> medQty = fillDict(itemsToShow);

            order = new Receipt(12, "apotekarko Apotekarkovic", "01.12.2021.", medQty, "", (float)14.1, "1");

            receiptController.CreateReceipt(order);
        }


        private Dictionary<string, int> fillDict(List<Medicine> cartItems)
        {
            var myDict = new Dictionary<string, int> { };
            foreach (var med in cartItems)
            {
                myDict.Add(med.Name, med.Amount);
            }

            return myDict;
        }

        /*
        this.Id = id;
            this.Pharmacist = pharmacist;
            this.DateAndTime = dateAndTime;
            this.MedQty = medQty;
            this.MedQtyString = medQtyStr;
            this.Price = price;
            this.UserJmbg = userJmbg;*/
    }
}
