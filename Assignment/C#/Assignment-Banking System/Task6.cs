using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_Banking_System
{
    internal class Task6
    {
        //Create a program that maintains a list of bank transactions(deposits and withdrawals) for a customer.
        //Use a while loop to allow the user to keep adding transactions until they choose to exit.
        //Display the transaction history upon exit using looping statements.
        public static void Transactions()
    {
        Console.WriteLine("Task6");
        Console.Write("Maximum Transactions: ");
        int maxTransactions = int.Parse(Console.ReadLine());
            string[] transactionType = new string[maxTransactions];
            double[] transactionAmount = new double[maxTransactions];
            int count = 0;
            Console.WriteLine("----Starting Transactions----");
            while (true)
            {
                if (count < maxTransactions)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Exit and Show Transaction History");
                    Console.Write("Choose an option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.Write("Enter deposit amount: ");
                        double amount = double.Parse(Console.ReadLine());
                        transactionType[count] = "Deposit";
                        transactionAmount[count] = amount;
                        count++;
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter withdrawal amount: ");
                        double amount = double.Parse(Console.ReadLine());
                        transactionType[count] = "Withdrawal";
                        transactionAmount[count] = amount;
                        count++;
                    }
                    else if (option == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }

                }
                else
                {
                    Console.WriteLine("Maximum number of transactions reached.");
                    break;
                }
                    
            }

            // Show transaction history
            Console.WriteLine("\n---- Transaction History ----");
            if (count == 0)
            {
                Console.WriteLine("No transactions made.");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{transactionType[i]}: {transactionAmount[i]}");
                }
            }
        }
    }
}
