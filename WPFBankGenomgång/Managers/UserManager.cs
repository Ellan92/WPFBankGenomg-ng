using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBankGenomgång.Models;

namespace WPFBankGenomgång.Managers
{
    public static class UserManager
    {
        public static List<User> Users { get; set; } = new()
        {
            new Client("test", "password"),
            new Admin("admin", "password"),
            new Client("bobross", "password"),
        };
        public static User? CurrentSignedInUser { get; set; }

        public static User? RegisterClient(string username, string password)
        {
            if (ValidateUsername(username))
            {
                Client newClient = new(username, password);

                Users.Add(newClient);

                return newClient;
            }

            return null;
        }

        private static bool ValidateUsername(string username)
        {
            bool isValidUsername = true;

            foreach(var user in Users)
            {
                if (user.Username == username)
                {
                    isValidUsername = false;
                }
            }
            return isValidUsername;
        }

        public static bool SignInUser(string username, string password)
        {
            foreach (var user in Users)
            {
                if(user.Username == username && user.Password == password)
                {
                    // User found! 
                    CurrentSignedInUser = user;

                    return true;
                }
            }
            return false;
        }

        public static void SignOutUser()
        {
            CurrentSignedInUser = null;
        }
    }
}
