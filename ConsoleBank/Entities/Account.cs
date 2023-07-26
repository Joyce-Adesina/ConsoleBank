using ConsoleBank.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    public class Account
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountNumber { get; set; } = new Random().Next(1119000000,1999999999); // Provide an initial value for AccountNumber
        public string AccountType { get; set; }
        public uint PIN { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal minBalance => AccountType == "saving" ? 1000 : 0;
    }
}
       
        
