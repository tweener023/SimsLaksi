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
        private UserController userController = new UserController();
        private MedicineController medicineController = new MedicineController();

        public DoctorMain()
        {
            InitializeComponent();
            this.DataContext = this;

            List<User> patientsToShow = userController.GetAllPatients();
            patientsDataGrid.ItemsSource = patientsToShow;

            List<Medicine> waitingMedicine = medicineController.GetByValidation(false); // trebaju nam ovi koji jos nisu prihvaceni
            waitingMedicineDataGrid.ItemsSource = waitingMedicine;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string jmbg = jmbgBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string phone = phoneBox.Text;

            userController.RegisterPatient(jmbg, email, password, firstname, lastname, phone);
        }

    }
}
