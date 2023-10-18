using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBankGenomgång.Models
{
    public class SavingsAccount : Account
    {
        public decimal Interest { get; set; }

        public SavingsAccount()
        {
            base.Balance = new Random().Next(0, 1001);
        }
    }
}
