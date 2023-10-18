using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBankGenomgång.Models
{
    public class Account
    {
        public int AccountNumber { get; set; } = Guid.NewGuid().GetHashCode();
        public decimal Balance { get; set; }

        public bool CheckBalance(decimal amount)
        {
            // Har vi nog med pengar på vårt konto?
            if(amount >= Balance)
            {
                return true;
            }

            return false;
        }
    }
}
