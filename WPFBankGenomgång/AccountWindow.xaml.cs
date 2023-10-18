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
using WPFBankGenomgång.Managers;
using WPFBankGenomgång.Models;

namespace WPFBankGenomgång
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();

            if(UserManager.CurrentSignedInUser!.GetType() == typeof(Client))
            {
                // Client is logged in
                Client signedInClient = (Client)UserManager.CurrentSignedInUser;

                txtSalaryAccountBalance.Text = signedInClient.SalaryAccount.Balance.ToString();
                txtSavingsAccountBalance.Text = signedInClient.SavingsAccount.Balance.ToString();

            }
            else if(UserManager.CurrentSignedInUser!.GetType() == typeof(Admin))
            {
                // Admin is logged in

                txtSalaryAccountBalance.Text = "N/A";
                txtSavingsAccountBalance.Text = "N/A";

                btnAdminView.Visibility = Visibility.Visible;
            }
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            // Logga ut användaren
            UserManager.SignOutUser();

            // Gå tillbaka till MainWindow
            MainWindow mainWindow = new();
            mainWindow.Show();

            // Stäng detta fönster
            Close();
        }
    }
}
