using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public TransactionType Type { get; set; }
        public int Amount { get; set; }
        public string TDate { get; set; }
    }

    public enum TransactionType
    {
        Withdraw = 1,
        Deposit = 2,
        FastPay= 3,
    }
}
