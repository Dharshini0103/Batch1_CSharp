using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bean;

/*namespace bean.AbstractClasses_Task11.Account
{
    
    
        
        public abstract class Account
        {
            private static long lastAccNo = 1000;


            public long AccountNumber { get; set; }
            public string AccountType { get; set; }
            public float AccountBalance { get; set; }
            public Customer Customer { get; set; }
            

        public Account(Customer customer, string accountType, float balance)
            {
                AccountNumber = ++lastAccNo;
                AccountType = accountType;
                AccountBalance = balance;
                Customer = customer;
            }

            public abstract float Withdraw(float amount);
        }

        public class SavingsAccount : Account
        {
            public float InterestRate { get; set; }

            public SavingsAccount(Customer customer, float balance, float interestRate)
                : base(customer, "Savings", balance >= 500 ? balance : throw new ArgumentException("Minimum balance should be 500"))
            {
                InterestRate = interestRate;
            }

            public override float Withdraw(float amount)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance -= amount;
                    return amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                    return 0;
                }
            }
        }

        public class CurrentAccount : Account
        {
            public float OverdraftLimit { get; set; }

            public CurrentAccount(Customer customer, float balance, float overdraftLimit)
                : base(customer, "Current", balance)
            {
                OverdraftLimit = overdraftLimit;
            }

            public override float Withdraw(float amount)
            {
                if (AccountBalance + OverdraftLimit >= amount)
                {
                    AccountBalance -= amount;
                }
                else
                {
                    throw new InvalidOperationException("Overdraft limit exceeded.");
                }
                return AccountBalance;
            }
        }

        public class ZeroBalanceAccount : Account
        {
            public ZeroBalanceAccount(Customer customer)
                : base(customer, "ZeroBalance", 0) { }

            public override float Withdraw(float amount)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance -= amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                return AccountBalance;
            }
        }
    

}*/

