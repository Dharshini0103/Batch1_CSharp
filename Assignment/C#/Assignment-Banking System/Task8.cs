using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using bean;
using app;
using service;


namespace Assignment_Banking_System
{
    internal class Task8
    {
        public static void Task8Run()
        {
            Console.WriteLine("Task8");
            Bank bank = new Bank();
            Console.WriteLine("Task 8");

            // Creating 2 accounts using menu
            Console.WriteLine("Creating First Account:");
            bank.CreateAccountWithMenu();

            Console.WriteLine("Creating Second Account:");
            bank.CreateAccountWithMenu();

            // Deposit
            double updatedBalance = bank.Withdraw(1001, 1000f);  
            Console.WriteLine("Balance after withdrawal: " + updatedBalance);

            // Withdraw
            Console.Write("Enter Account Number to Withdraw: ");
            long withdrawAcc = long.Parse(Console.ReadLine());
            bank.Withdraw(withdrawAcc, 1000f);

            // Transfer
            Console.Write("Enter From Account Number for Transfer: ");
            long fromAcc = long.Parse(Console.ReadLine());
            Console.Write("Enter To Account Number for Transfer: ");
            long toAcc = long.Parse(Console.ReadLine());
            bank.Transfer(fromAcc, toAcc, 2000f);

            // Get Account Details
            Console.Write("Enter Account Number to View Details: ");
            long viewAcc = long.Parse(Console.ReadLine());
            bank.GetAccountDetails(viewAcc);
        }

        public static Account FindAccount(Bank bank, long accountNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                Account acc = bank.GetAccountByIndex(i);
                if (acc == null) break;
                if (acc.AccountNumber == accountNumber)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}
