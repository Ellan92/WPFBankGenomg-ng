using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WPFBankGenomgång.Models
{
    public class Client : User
    {
        public SalaryAccount SalaryAccount { get; set; } = new();
        public SavingsAccount SavingsAccount { get; set; } = new();

        public Client(string username, string password) : base(username, password)
        {
            
        }
    }
}
