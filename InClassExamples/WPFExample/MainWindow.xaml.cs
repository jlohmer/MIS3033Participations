//Jason Lohmer
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

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txt_firstName.Text = "";
            txt_lastName.Text = string.Empty;
            txt_birthdate.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            lst_letters.Items.Clear();
            string firstName, lastName, birthDate;
            firstName = txt_firstName.Text;
            lastName = txt_lastName.Text;
            birthDate = txt_birthdate.Text;

            string fullName = firstName + " " + lastName;
            DateTime dob = Convert.ToDateTime(birthDate);

            foreach (var letter in fullName)
            {
                lst_letters.Items.Add(letter);
            }

            lst_letters.Items.Add($"You were born on a {dob.DayOfWeek}.");
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you for using our application :)");
            Close();
        }
    }
}
