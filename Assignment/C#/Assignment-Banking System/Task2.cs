using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_Banking_System
{
    internal class Task2
    {
        //Create a program that simulates an ATM transaction.Display options such as "Check Balance," "Withdraw," "Deposit,". Ask the user to enter their current balance and the amount they want to withdraw or deposit.
        //Implement checks to ensure that the withdrawal amount is not greater than the available balance and that the withdrawal amount is in multiples of 100 or 500. Display appropriate messages for success or failure.
        public static void Transactions()
        {
            Console.WriteLine("Task2");
            Console.Write("Balance : ");
            double Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine($"Your current balance is: {Balance}");
            }
            else if (option == 2)
            {
                Console.Write("Withdrawal Amount: ");
                int Withdrawal_Amount = int.Parse(Console.ReadLine());
                if (Withdrawal_Amount < Balance)
                {
                    if (Withdrawal_Amount % 100 == 0 || Withdrawal_Amount % 500 == 0)
                    {
                        Balance -= Withdrawal_Amount;
                        Console.WriteLine($"Withdrawal successful! New balance: {Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Withdrawal amount must be in multiples of 100 or 500.");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else if (option == 3)
            {
                Console.Write("Enter amount to deposit: ");
                double Deposit_Amount = double.Parse(Console.ReadLine());

                if (Deposit_Amount > 0)
                {
                    Balance += Deposit_Amount;
                    Console.WriteLine($"Deposited-New balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Error: Deposit amount must be greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }
}






            



        
          

