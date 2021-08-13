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
        MedicineController medicineController = new MedicineController();

        public PharmacistMain()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void onRegisterMedicine(object sender, RoutedEventArgs e)
        {
            string code = registerCodeBox.Text;
            string name = registerNameBox.Text;
            string manufacturer = registerManufacturerBox.Text;

            string pri = registerPriceBox.Text;
            float price = float.Parse(pri);

            string amn = registerAmountBox.Text;
            int amount = Convert.ToInt32(amn);

            string ings = registerIngredientsBox.Text;
            List<string> ingsString = ings.Split(',').ToList();

            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var i in ingsString)
            {
                var data = new Ingredient(i, "Lorem ipsum....");
                ingredients.Add(data);
            }


            medicineController.CreateMedicine(code, name, manufacturer, price, amount, ingredients);
        }
    }
}
