using Controller;
using Model;
using Project.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        App app = (App)Application.Current;

        User logedUser;
        int counter;
        public MainWindow()
        {
            InitializeComponent();
            counter = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e) //doc button
        {
          //  this.Hide();

            DoctorMain n = new DoctorMain();
            n.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //pat button
        {
           // this.Hide();

            PatientMain n = new PatientMain(logedUser);
            n.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //pharm button
        {
         //   this.Hide();

            PharmacistMain n = new PharmacistMain();
            n.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //login
        {
            string jmbg = loginJmbg.Text;
            string pw = loginPassword.Text;
            logedUser = app.userController.GetByJmbg(jmbg);

            if (counter > 2)
            {
                Close();
            }

            if (logedUser == null)
            {
                MessageBox.Show("Pogresan jmbg");
                counter++;
            }
            else if (logedUser.Password != pw)
            {
                MessageBox.Show("Pogresna sifra");
                counter++;
            }
            else
            {
                if (logedUser.UserType == 0)
                {
                    this.Hide();
                    PatientMain patientMain = new PatientMain(logedUser);
                    patientMain.Show();
                }
                else if (logedUser.UserType == (UserType)1)
                {
                    this.Hide();
                    DoctorMain doctorMain = new DoctorMain();
                    doctorMain.Show();
                }
                else
                {
                    this.Hide();
                    PharmacistMain pharmacistMain = new PharmacistMain();
                    pharmacistMain.Show();
                }
            }


        }

    }
}