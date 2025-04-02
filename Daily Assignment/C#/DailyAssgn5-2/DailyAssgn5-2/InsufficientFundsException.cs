using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAssgn5_2
{
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string msg) : base(msg) { }
    }
    class BankAccount
    {
        double Balance;
        public BankAccount(double balance) { Balance = balance; }

        public void TransferFunds(double amount)
        {
            if (amount > Balance) throw new InsufficientFundsException("Insufficient balance!");
            Balance -= amount;
            Console.WriteLine($"Transaction is successful! Remaining: Rs.{Balance}");
        }
    }

}
