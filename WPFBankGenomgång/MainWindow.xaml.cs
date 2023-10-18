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
using WPFBankGenomgång.Managers;

namespace WPFBankGenomgång
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            // Läs innehållet i username och password-textrutorna

            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Använd Usermanager för att logga in

            bool isSuccessfulSignIn = UserManager.SignInUser(username, password);

            // Lyckas inloggningen... Öppna AccountWindow
            if (isSuccessfulSignIn)
            {
                AccountWindow accountWindow = new();
                accountWindow.Show();
                Close();
            }
            // Misslyckas inloggningen... Visa varningsmeddelande!
            else
            {
                MessageBox.Show("Invalid username or password", "Warning");
            }


        }
    }
}
