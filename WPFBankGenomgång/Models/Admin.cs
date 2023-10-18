using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBankGenomgång.Models
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password)
        {
            
        }
    }
}
