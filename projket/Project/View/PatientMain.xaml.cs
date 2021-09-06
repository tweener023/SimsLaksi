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
        App app = (App)Application.Current;

        //private ReceiptController receiptController = new ReceiptController();
        //private MedicineController medicineController = new MedicineController();

        List<Receipt> receiptsToShow;

        List<Ingredient> ingredientsToShow;
        List<Medicine> allMedicines;
        List<Medicine> acceptedMedicine;
        List<Medicine> waitingMedicine;
        List<User> patientsToShow;


        List<Medicine> cartList = new List<Medicine>();

        // ObservableCollection<Medicine> cartToShow = new ObservableCollection<Medicine>();


        public PatientMain(User logedUser)
        {
            InitializeComponent();
            currentUser = logedUser;


            acceptedMedicine = app.medicineController.GetByValidation(true); // trebaju nam ovi koji su prihvaceni accepted=true
            medicineDataGrid.ItemsSource = acceptedMedicine;

            receiptsToShow = app.receiptController.GetByUserJmbg(currentUser.Jmbg);
            receiptsDataGrid.ItemsSource = receiptsToShow;

            allMedicines = app.medicineController.GetAll();

            acceptedMedicine = app.medicineController.GetByValidation(true); // trebaju nam ovi koji su prihvaceni accepted=true
            medicineDataGrid.ItemsSource = acceptedMedicine;

            medicineCombo.ItemsSource = acceptedMedicine;

            //waitingMedicine = app.medicineController.GetByValidation(false); // trebaju nam ovi koji jos nisu prihvaceni accepted=false
            //waitingMedicineDataGrid.ItemsSource = waitingMedicine;

            ingredientsToShow = app.ingredientController.GetAll();
            ingredientsDataGrid.ItemsSource = ingredientsToShow;
        }

 
        #region medicine search
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
                try
                {
                    if (m.Price > float.Parse(searchByPriceFrom.Text) && m.Price < float.Parse(searchByPriceTo.Text))
                    {
                        acceptedMedicinesByPrice.Add(m);
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("You must enter a valid value.");
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
                try
                {
                    if (m.Amount == Int32.Parse(searchByAmount.Text))
                    {
                        acceptedMedicinesByAmount.Add(m);
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("You must enter a valid value.");
                }
            }
            medicineDataGrid.ItemsSource = acceptedMedicinesByAmount;
        }

        private void onSearchMedicineByIngredients(object sender, RoutedEventArgs e)
        {
            string ingredientToSearch = searchByIngredient.Text;

            if (ingredientToSearch == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Medicine> acceptedMedicineByIngredient = new List<Medicine>();

            foreach (var medicine in acceptedMedicine)
            {
                foreach (var ingredient in medicine.Ingredients)
                {
                    if (ingredientToSearch == ingredient.Name)
                    {
                        acceptedMedicineByIngredient.Add(medicine);
                    }
                }
            }

            medicineDataGrid.ItemsSource = acceptedMedicineByIngredient;
        }

        #endregion


        #region ingredient search
        private void onSearchIngredientByName(object sender, RoutedEventArgs e)
        {
            if (searchIngredientByName.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Ingredient> ingredientsByName = new List<Ingredient>();
            foreach (var i in ingredientsToShow)
            {
                if (i.Name.ToLower().Contains(searchIngredientByName.Text.ToLower()))
                {
                    ingredientsByName.Add(i);
                }
            }
            ingredientsDataGrid.ItemsSource = ingredientsByName;
        }

        private void onSearchIngredientByDescription(object sender, RoutedEventArgs e)
        {
            if (searchIngredientByDescription.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            List<Ingredient> ingredientsByDesc = new List<Ingredient>();
            foreach (var i in ingredientsToShow)
            {
                if (i.Description.ToLower().Contains(searchIngredientByDescription.Text.ToLower()))
                {
                    ingredientsByDesc.Add(i);
                }
            }

            ingredientsDataGrid.ItemsSource = ingredientsByDesc;
        }

        private void onSearchIngredientByMedicine(object sender, RoutedEventArgs e)
        {
            foreach (var medicine in allMedicines)
            {
                if (medicine.Name == ((Medicine)(medicineCombo.SelectedItem)).Name)
                {
                    ingredientsDataGrid.ItemsSource = medicine.Ingredients;
                }
            }
        }

        #endregion

        #region add to cart functionalities
        private void onAddToCart(object sender, RoutedEventArgs e)
        {
            // otvara se messagebox tj neki dialog box u kojem ce da unese kolicinu
            // Interaction.InputBox("Amount?", "mrs", "69");

            Medicine medToCart = (Medicine)medicineDataGrid.SelectedItem;

            int medAmount = Int32.Parse(medicineAmount.Text);

            if (medAmount > medToCart.Amount || medAmount > 5)
            {
                MessageBox.Show("you cant order more than 5!");
            }
            else
            {
                medToCart.Amount = Int32.Parse(medicineAmount.Text);
                cartList.Add(medToCart);
                MessageBox.Show("medicine added to cart!");
            }
        }

        private void onCheckout(object sender, RoutedEventArgs e)
        {
            Checkout checkoutWindow = new Checkout(cartList, currentUser);
            checkoutWindow.Show();
        }

        #endregion
    }
}
