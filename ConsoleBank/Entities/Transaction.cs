using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Entities
{
    public class Transaction
    { 
        public string TransactionDetails { get; set; }
        public string TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public string ReceiverAccount { get; set; }
        public string SenderAccount { get; set; }
        public DateTime TransactionDate { get; set; }=DateTime.Now;

    }
}
