using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Banking_System
{
    internal class Task4
    //1.Create a  program that simulates a bank with multiple customer accounts
    {
        public static void account_balance()
        {
            Console.WriteLine("Task4");
            Console.Write("Number of customers: ");
            int No_of_Customers = int.Parse(Console.ReadLine());
            string[] Account_Number = new string[No_of_Customers];
            double[] Balance = new double[No_of_Customers];
            int i = 0;
            //2.Use a loop (e.g., while loop) to repeatedly ask the user for their account number and balance until they enter a valid account number
            while (i<No_of_Customers)
            {
                Console.Write($"Enter Account Number for Customer{i + 1}: ");
                Account_Number[i] = Console.ReadLine();
                //3.Validate the account number entered by the user
                if (Account_Number[i].Length == 10) 
                {
                    Console.Write($"Enter Balance for Account {Account_Number[i]}: ");
                    Balance[i] = double.Parse(Console.ReadLine()); 
                    i++;  
                }
                else
                {
                    Console.WriteLine("Invalid Account Number! Please Try again");
                }
            }
            //4.If the account number is valid, display the account balance. If not, ask the user to try again
            Console.Write("\nEnter an Account Number to check balance: ");
            string searchAccount = Console.ReadLine();
            int index = Array.IndexOf(Account_Number, searchAccount);
            if (index != -1)
                Console.WriteLine($"Balance for Account {searchAccount}: ₹{Balance[index]}");
            else
                Console.WriteLine("Account Number Not Found.");
        }

    }
}
