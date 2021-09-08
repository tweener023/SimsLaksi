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
        // ReceiptController receiptController = new ReceiptController();
        App app = (App)Application.Current;


        private List<Medicine> itemsToShow = new List<Medicine>();
        private Receipt order;

        private User currentUser;
        float price;

        public Checkout(List<Medicine> toShow, User cU)
        {
            InitializeComponent();

            currentUser = cU;
            itemsToShow = toShow;
            cartDataGrid.ItemsSource = itemsToShow;
            price = 0;
        }

        private void onOrder(object sender, RoutedEventArgs e)
        {
            // dodaj da pokupi date and time

            Dictionary<string, int> medQty = fillDict(itemsToShow);
            Random rand = new Random();

            string medQtyString = string.Join(", ", medQty.Select(kv => kv.Key + ": " + kv.Value).ToArray());


            order = new Receipt(rand.Next(1, 100), "Apotekarko Apotekarkovic", DateTime.Now.ToString("dd.mm.yyyy."), medQty, medQtyString, price, currentUser.Jmbg);

            app.receiptController.CreateReceipt(order);


            MessageBoxResult res = MessageBox.Show("Order placed!");
            Close();

        }

        private Dictionary<string, int> fillDict(List<Medicine> cartItems)
        {

            var myDict = new Dictionary<string, int> { };
            foreach (var med in cartItems)
            {
                myDict.Add(med.Name, med.Amount);
                price += med.Price * med.Amount;
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
