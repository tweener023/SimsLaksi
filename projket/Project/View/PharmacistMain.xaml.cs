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
    /// Interaction logic for PharmacistMain.xaml
    /// </summary>
    public partial class PharmacistMain : Window
    {

        App app = (App)Application.Current;

        List<Ingredient> ingredientsToShow;
        List<Medicine> allMedicines;
        List<Medicine> acceptedMedicine;
        List<Medicine> rejectedMedicine;

        bool flag = false;

        public PharmacistMain()
        {
            InitializeComponent();
            this.DataContext = this;

            allMedicines = app.medicineController.GetAll();
            medicineDataGrid.ItemsSource = allMedicines;

            acceptedMedicine = app.medicineController.GetByValidation(true); // trebaju nam ovi koji su prihvaceni accepted=true
            rejectedMedicine = app.medicineController.GetByValidation(false); // trebaju nam ovi koji su prihvaceni accepted=false

            acceptedMedicineDataGrid.ItemsSource = acceptedMedicine;
            rejectedMedicineDataGrid.ItemsSource = rejectedMedicine;


            medicineCombo.ItemsSource = acceptedMedicine;

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


        #region rejected accepted medicine search

        private void onSearchMedicineByCodeRA(object sender, RoutedEventArgs e)
        {
            if (searchByCodeRA.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            if (acceptedRadio.IsChecked == true)
            {
                Console.WriteLine("usao");
                List<Medicine> acceptedMedicinesByCode = new List<Medicine>();
                foreach (var m in acceptedMedicine)
                {
                    if (m.Code.ToLower().Contains(searchByCodeRA.Text.ToLower()))
                    {
                        acceptedMedicinesByCode.Add(m);
                    }
                }
                acceptedMedicineDataGrid.ItemsSource = acceptedMedicinesByCode;
            }
            else
            {
                List<Medicine> rejectedMedicinesByCode = new List<Medicine>();
                foreach (var m in rejectedMedicine)
                {
                    if (m.Code.ToLower().Contains(searchByCodeRA.Text.ToLower()))
                    {
                        rejectedMedicinesByCode.Add(m);
                    }
                }
                rejectedMedicineDataGrid.ItemsSource = rejectedMedicinesByCode;
            }
        }

        private void onSearchMedicineByNameRA(object sender, RoutedEventArgs e)
        {

            if (searchByNameRA.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            if (acceptedRadio.IsChecked == true)
            {
                List<Medicine> acceptedMedicinesByName = new List<Medicine>();
                foreach (var m in acceptedMedicine)
                {
                    if (m.Name.ToLower().Contains(searchByNameRA.Text.ToLower()))
                    {
                        acceptedMedicinesByName.Add(m);
                    }
                }
                acceptedMedicineDataGrid.ItemsSource = acceptedMedicinesByName;
            }
            else
            {
                List<Medicine> rejectedMedicinesByName = new List<Medicine>();
                foreach (var m in rejectedMedicine)
                {
                    if (m.Name.ToLower().Contains(searchByNameRA.Text.ToLower()))
                    {
                        rejectedMedicinesByName.Add(m);
                    }
                }
                rejectedMedicineDataGrid.ItemsSource = rejectedMedicinesByName;
            }
        }

        private void onSearchMedicineByManufacturerRA(object sender, RoutedEventArgs e)
        {
            if (searchByManufacturerRA.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }


            if (acceptedRadio.IsChecked == true)
            {
                List<Medicine> acceptedMedicinesByMnf = new List<Medicine>();
                foreach (var m in acceptedMedicine)
                {
                    if (m.Manufacturer.ToLower().Contains(searchByManufacturerRA.Text.ToLower()))
                    {
                        acceptedMedicinesByMnf.Add(m);
                    }
                }
                acceptedMedicineDataGrid.ItemsSource = acceptedMedicinesByMnf;
            }
            else
            {
                List<Medicine> rejectedMedicinesByMnf = new List<Medicine>();
                foreach (var m in rejectedMedicine)
                {
                    if (m.Manufacturer.ToLower().Contains(searchByManufacturerRA.Text.ToLower()))
                    {
                        rejectedMedicinesByMnf.Add(m);
                    }
                }
                rejectedMedicineDataGrid.ItemsSource = rejectedMedicinesByMnf;
            }
        }

        private void onSearchMedicineByPriceRA(object sender, RoutedEventArgs e)
        {
            if (searchByPriceFromRA.Text == "" || searchByPriceToRA.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            if (acceptedRadio.IsChecked == true)
            {
                List<Medicine> acceptedMedicinesByPrice = new List<Medicine>();
                foreach (var m in acceptedMedicine)
                {
                    try
                    {
                        if (m.Price > float.Parse(searchByPriceFromRA.Text) && m.Price < float.Parse(searchByPriceToRA.Text))
                        {
                            acceptedMedicinesByPrice.Add(m);
                        }
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("You must enter a valid value.");
                    }
                }
                acceptedMedicineDataGrid.ItemsSource = acceptedMedicinesByPrice;
            }
            else
            {
                List<Medicine> rejectedMedicinesByPrice = new List<Medicine>();
                foreach (var m in rejectedMedicine)
                {
                    try
                    {
                        if (m.Price > float.Parse(searchByPriceFromRA.Text) && m.Price < float.Parse(searchByPriceToRA.Text))
                        {
                            rejectedMedicinesByPrice.Add(m);
                        }
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("You must enter a valid value.");
                    }
                }
                rejectedMedicineDataGrid.ItemsSource = rejectedMedicinesByPrice;
            }
        }

        private void onSearchMedicineByAmountRA(object sender, RoutedEventArgs e)
        {
            if (searchByAmountRA.Text == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            if (acceptedRadio.IsChecked == true)
            {
                List<Medicine> acceptedMedicinesByAmount = new List<Medicine>();
                foreach (var m in acceptedMedicine)
                {
                    try
                    {
                        if (m.Amount == Int32.Parse(searchByAmountRA.Text))
                        {
                            acceptedMedicinesByAmount.Add(m);
                        }
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("You must enter a valid value.");
                    }
                }
                acceptedMedicineDataGrid.ItemsSource = acceptedMedicinesByAmount;
            }
            else
            {
                List<Medicine> rejectedMedicinesByAmount = new List<Medicine>();
                foreach (var m in rejectedMedicine)
                {
                    try
                    {
                        if (m.Amount == Int32.Parse(searchByAmountRA.Text))
                        {
                            rejectedMedicinesByAmount.Add(m);
                        }
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("You must enter a valid value.");
                    }
                }
                rejectedMedicineDataGrid.ItemsSource = rejectedMedicinesByAmount;
            }
        }

        private void onSearchMedicineByIngredientsRA(object sender, RoutedEventArgs e)
        {
            string ingredientToSearch = searchByIngredientRA.Text;

            if (ingredientToSearch == "")
            {
                MessageBox.Show("You must enter a valid value.");
            }

            if (acceptedRadio.IsChecked == true)
            {
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

                acceptedMedicineDataGrid.ItemsSource = acceptedMedicineByIngredient;
            }
            else
            {
                List<Medicine> rejectedMedicineByIngredient = new List<Medicine>();

                foreach (var medicine in rejectedMedicine)
                {
                    foreach (var ingredient in medicine.Ingredients)
                    {
                        if (ingredientToSearch == ingredient.Name)
                        {
                            rejectedMedicineByIngredient.Add(medicine);
                        }
                    }
                }

                rejectedMedicineDataGrid.ItemsSource = rejectedMedicineByIngredient;
            }
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

        #region medicine functions

        private void onDeleteMedicine(object sender, RoutedEventArgs e)
        {
            Medicine medToUp = (Medicine)medicineDataGrid.SelectedItem;

            if (medToUp == null)
            {
                MessageBox.Show("you must select an item!");
            }
            else
            {
                app.medicineController.DeleteMedicine(medToUp);
                MessageBox.Show("Medicine deleted");
            }
        }

        private void onRegisterMedicine(object sender, RoutedEventArgs e)
        {
            string code = registerCodeBox.Text;
            string name = registerNameBox.Text;
            string manufacturer = registerManufacturerBox.Text;

            string pri = registerPriceBox.Text;
            float price = 0;
            flag = false;


            foreach (var med in allMedicines)
            {
                if (code == med.Code)
                {
                    MessageBox.Show("Code must be unique!");
                    flag = true;
                }
            }

            try
            {
                price = float.Parse(pri);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid price!");
                flag = true;
            }

            string amn = registerAmountBox.Text;
            int amount = 0;
            try
            {
                amount = Convert.ToInt32(amn);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid price!");
                flag = true;
            }

            string ings = registerIngredientsBox.Text;
            List<string> ingredientsString = ings.Split(',').ToList();

            List<Ingredient> ingredients = new List<Ingredient>();
            Ingredient ingredientToUpdate;

            foreach (var ingredientName in ingredientsString)
            {
                ingredientToUpdate = app.ingredientController.GetByName(ingredientName);
                if (ingredientToUpdate == null)
                {
                    MessageBox.Show("you must enter valid ingredient name!");
                    flag = true;
                    //break;
                }
                else
                {
                    ingredientToUpdate.CountInMedicines++;
                    ingredients.Add(ingredientToUpdate);
                }
            }

            if (!flag)
            {
                app.medicineController.CreateMedicine(code, name, manufacturer, price, amount, ingredients);
                MessageBox.Show("Medicine registered!");
            }
        }
        #endregion

    }
}
