using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using bean;
using service;
using app;

namespace Assignment_Banking_System
{
    internal class Task9
    {
        public abstract class BankAccount
        {
            public string Account_number;
            public string Customer_Name;
            public double Balance;

            // Default constructor
            public BankAccount()
            {
                Account_number = "Not Set";
                Customer_Name = "Not Set";
                Balance = 0.0;
            }

            
            public BankAccount(string accNo, string custName, double balance)
            {
                Account_number = accNo;
                Customer_Name = custName;
                Balance = balance;
            }

            // Getters and Setters
            public string Acc_Number
            {
                get { return Account_number; }
                set { Account_number = value; }
            }

            public string CustomerName
            {
                get { return Customer_Name; }
                set { Customer_Name = value; }
            }

            public double balance
            {
                get { return Balance; }
                set { Balance = value; }
            }

            // Display method
            public void DisplayAccountInfo()
            {
                Console.WriteLine("---- Account Details ----");
                Console.WriteLine("Account Number: " + Account_number);
                Console.WriteLine("Customer Name: " + Customer_Name);
                Console.WriteLine("Balance: " + Balance);
            }

            // Abstract methods
            public abstract void Deposit(float amount);
            public abstract void Withdraw(float amount);
            public abstract float CalculateInterest();
        }

        // Savings Account class
        public class SavingsAccount : BankAccount
        {
            public float InterestRate { get; set; }

            public SavingsAccount(string accNo, string custName, double balance, float interestRate)
                : base(accNo, custName, balance)
            {
                InterestRate = interestRate;
            }

            public override void Deposit(float amount)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }

            public override void Withdraw(float amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdrawn: " + amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            public override float CalculateInterest()
            {
                float interest = (float)Balance * InterestRate / 100;
                Balance += interest;
                Console.WriteLine("Interest (" + InterestRate + "%): " + interest);
                return interest;
            }
        }

        // Current Account class
        public class CurrentAccount : BankAccount
        {
            private const float OverdraftLimit = 10000;

            public CurrentAccount(string accNo, string custName, double balance)
                : base(accNo, custName, balance)
            {
            }

            public override void Deposit(float amount)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }

            public override void Withdraw(float amount)
            {
                if (Balance + OverdraftLimit >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdrawn: " + amount);
                }
                else
                {
                    Console.WriteLine("Withdrawal exceeds overdraft limit.");
                }
            }

            public override float CalculateInterest()
            {
                Console.WriteLine("No interest for Current Account.");
                return 0;
            }
        }
        public static void Task9Run()
        {
            Bank bank = new Bank();

            // Create two accounts manually using CreateAccountWithMenu()
            Console.WriteLine("\n--- Creating Account  ---");
            bank.CreateAccountWithMenu(); // user enters details in console


            // Now fetch account numbers from stored accounts (optional, if you want to automate)
            long acc1 = 1001; // assume this is the first created account number
            long acc2 = 1002; // assume this is the second created account number

            // -------------------- TASK 8 METHODS -------------------------

            Console.WriteLine("\n--- Depositing Rs.5000 to Account 1 ---");
            bank.Deposit(acc1, 5000f);

            Console.WriteLine("\n--- Withdrawing Rs.2000 from Account 1 ---");
            bank.Withdraw(acc1, 2000f);

            Console.WriteLine("\n--- Transferring Rs.1000 from Account 1 to Account 2 ---");
            bank.Transfer(acc1, acc2, 1000f);

            Console.WriteLine("\n--- Getting Balance of Account 1 ---");
            double bal1 = bank.GetAccountBalance(acc1);
            Console.WriteLine($"Balance in Account 1: Rs.{bal1}");

            Console.WriteLine("\n--- Getting Details of Account 1 ---");
            bank.GetAccountDetails(acc1);

            Console.WriteLine("\n--- Getting Details of Account 2 ---");
            bank.GetAccountDetails(acc2);
            
        }


    }
}
