using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Banking_System
{
    internal class Task3
    {
        //Task3
        //1.Create a program that calculates the future balance of a savings account
        public static void Balance_Calculation()
        {
            Console.WriteLine("Task3");
            Console.Write("No of Customers: ");
            int No_of_Customers=int.Parse(Console.ReadLine());
            //2.Use a loop structure (e.g., for loop) to calculate the balance for multiple customers
            for (int i=1;i<=No_of_Customers;i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Customer{i} details: ");
                //3.Prompt the user to enter the initial balance, annual interest rate, and the number of years
                Console.Write("Initial Balance: ");
                double Initial_Balance = double.Parse(Console.ReadLine());
                Console.Write("Annual Interest Rate: ");
                double Annual_Interest_Rate = double.Parse(Console.ReadLine());
                Console.Write("Number of years: ");
                double Years = double.Parse(Console.ReadLine());
                //4.Calculate the future balance using the formula
                double future_balance= Initial_Balance * Math.Pow ((1 + Annual_Interest_Rate / 100),Years);
                //5.Display the future balance for each customer
                Console.WriteLine($"Future balance after {Years} years: {future_balance}");
            }

        }
        
    }
}
