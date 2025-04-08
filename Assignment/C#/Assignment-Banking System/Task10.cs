using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bean;
using service;
using app;

namespace Assignment_Banking_System
{
    internal class Task10
    {
        private static long accNo;

        public static void Task10Run()
        {
            Console.WriteLine("Task10");
            Bank bank = new Bank();

            Console.Write("Enter how many operations you want to perform: ");
            int limit = int.Parse(Console.ReadLine());

            BankApp.Bankapp();

            Console.WriteLine("\nReached max operations. Program ended.");
        }

    }
}


