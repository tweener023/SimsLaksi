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
    /// Interaction logic for PatientMain.xaml
    /// </summary>
    public partial class PatientMain : Window
    {
        private User currentUser;
        private ReceiptController receiptController = new ReceiptController();
        private MedicineController medicineController = new MedicineController();

        List<Receipt> receiptsToShow;
        List<Medicine> acceptedMedicine;

        List<Medicine> cartList = new List<Medicine>();


        public PatientMain(User logedUser)
        {
            InitializeComponent();
            currentUser = logedUser;


            acceptedMedicine = medicineController.GetByValidation(true); // trebaju nam ovi koji su prihvaceni accepted=true
            medicineDataGrid.ItemsSource = acceptedMedicine;

            receiptsToShow = receiptController.GetByUserJmbg(currentUser.Jmbg);
            receiptsDataGrid.ItemsSource = receiptsToShow;
        }

        private void onAddToCart(object sender, RoutedEventArgs e)
        {
            // otvara se messagebox tj neki dialog box u kojem ce da unese kolicinu
            // Interaction.InputBox("Amount?", "mrs", "69");

            Medicine medToCart = (Medicine)medicineDataGrid.SelectedItem;

            int medAmount = Int32.Parse(medicineAmount.Text);

            if (medAmount > medToCart.Amount || medAmount > 5)
            {
                MessageBox.Show("ne moze toliko brt");
            }
            else
            {
                medToCart.Amount = Int32.Parse(medicineAmount.Text);
                cartList.Add(medToCart);
            }
        }

        private void onSearchMedicineByCode(object sender, RoutedEventArgs e)
        {
            if (searchByCode.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Medicine> acceptedMedicinesByCode = new List<Medicine>();
            foreach (var m in acceptedMedicine)
            {
                if (m.Code.ToLower().Contains(searchByCode.Text.ToLower()))
                {
                    acceptedMedicinesByCode.Add(m);
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByCode;
        }

        private void onSearchMedicineByName(object sender, RoutedEventArgs e)
        {

            if (searchByName.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Medicine> acceptedMedicinesByName = new List<Medicine>();
            foreach (var m in acceptedMedicine)
            {
                if (m.Name.ToLower().Contains(searchByName.Text.ToLower()))
                {
                    acceptedMedicinesByName.Add(m);
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByName;
        }

        private void onSearchMedicineByManufacturer(object sender, RoutedEventArgs e)
        {
            if (searchByManufacturer.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Medicine> acceptedMedicinesByMnf = new List<Medicine>();
            foreach (var m in acceptedMedicine)
            {
                if (m.Manufacturer.ToLower().Contains(searchByManufacturer.Text.ToLower()))
                {
                    acceptedMedicinesByMnf.Add(m);
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByMnf;
        }


        private void onSearchMedicineByPrice(object sender, RoutedEventArgs e)
        {
            if (searchByPriceFrom.Text == "" || searchByPriceTo.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }
            List<Medicine> acceptedMedicinesByPrice = new List<Medicine>();
            foreach (var m in acceptedMedicine)
            {
                if (m.Price > float.Parse(searchByPriceFrom.Text) && m.Price < float.Parse(searchByPriceTo.Text))
                {
                    acceptedMedicinesByPrice.Add(m);
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByPrice;
        }
        private void onSearchMedicineByAmount(object sender, RoutedEventArgs e)
        {
            if (searchByAmount.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Medicine> acceptedMedicinesByAmount = new List<Medicine>();
            foreach (var m in acceptedMedicine)
            {
                if (m.Amount == Int32.Parse(searchByAmount.Text))
                {
                    acceptedMedicinesByAmount.Add(m);
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByAmount;
        }

        private void onSearchMedicineByIngredients(object sender, RoutedEventArgs e)
        {

        }

        private void onOrder(object sender, RoutedEventArgs e)
        {

        }

        private void onCheckout(object sender, RoutedEventArgs e)
        {
            Checkout checkoutWindow = new Checkout(cartList);
            checkoutWindow.Show();
        }

    }

}
