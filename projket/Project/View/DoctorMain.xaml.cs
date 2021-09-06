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
    /// Interaction logic for DoctorMain.xaml
    /// </summary>
    public partial class DoctorMain : Window
    {
        App app = (App)Application.Current;

        //private UserController userController = new UserController();
        //private MedicineController medicineController = new MedicineController();
        //private IngredientController ingredientController = new IngredientController();


        List<Ingredient> ingredientsToShow;
        List<Medicine> allMedicines;
        List<Medicine> acceptedMedicine;
        List<Medicine> waitingMedicine;
        List<User> patientsToShow;

        bool flag = false;

        public DoctorMain()
        {
            InitializeComponent();
            this.DataContext = this;

            allMedicines = app.medicineController.GetAll();


            patientsToShow = app.userController.GetAllPatients();
            patientsDataGrid.ItemsSource = patientsToShow;

            acceptedMedicine = app.medicineController.GetByValidation(true); // trebaju nam ovi koji su prihvaceni accepted=true
            medicineDataGrid.ItemsSource = acceptedMedicine;

            medicineCombo.ItemsSource = acceptedMedicine;

            waitingMedicine = app.medicineController.GetByValidation(false); // trebaju nam ovi koji jos nisu prihvaceni accepted=false
            waitingMedicineDataGrid.ItemsSource = waitingMedicine;

            ingredientsToShow = app.ingredientController.GetAll();
            ingredientsDataGrid.ItemsSource = ingredientsToShow;
        }



        #region functionalities on medicines, accept, reject
        private void onAcceptMedicine(object sender, RoutedEventArgs e)
        {
            Medicine medToUp = (Medicine)waitingMedicineDataGrid.SelectedItem;

            if (medToUp == null)
            {
                MessageBox.Show("you must select an item!");
            }
            else
            {
                app.medicineController.AcceptMedicine(medToUp);
                MessageBox.Show("Medicine accepted!");
            }
        }

        private void onRejectMedicine(object sender, RoutedEventArgs e)
        {
            Medicine medToUp = (Medicine)waitingMedicineDataGrid.SelectedItem;

            if (medToUp == null)
            {
                MessageBox.Show("you must select an item!");

            }
            else
            {
                app.medicineController.RejectMedicine(medToUp);
                MessageBox.Show("Medicine rejected with message: " + rejectMessage.Text);
                rejectMessage.Text = "";
            }
        }

        #endregion

        #region functionalities on patient
        private void onRegisterPatient(object sender, RoutedEventArgs e)
        {
            string jmbg = jmbgBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string phone = phoneBox.Text;

            flag = false;

            foreach (var patient in patientsToShow)
            {
                if (jmbg == patient.Jmbg || email == patient.Email)
                {
                    MessageBox.Show("paatient with this email or jmbg already exists!");
                    flag = true;
                }
            }

            if (!flag)
            {
                app.userController.RegisterPatient(jmbg, email, password, firstname, lastname, phone);
                MessageBox.Show("Patient created");
            }
        }

        #endregion
        #region searches on ingredients
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

        #region searches on medicines
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
    }
}
