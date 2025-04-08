using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bean;
using service;
using app;
using SavingsAcc = bean.SavingsAccount;
using CurrentAcc = bean.CurrentAccount;


namespace Assignment_Banking_System
{
    internal class Task13
    {
        public static void Task13Run()
        {
            Console.WriteLine("Task 13");

            // Sample customers
            Customer cust1 = new Customer("Dharshini", "V M", "aadhya@gmail.com", "9876543210", "Chennai");
            Customer cust2 = new Customer("Harini", "T P", "bhargav@gmail.com", "9123456789", "Bangalore");
            //Customer cust3 = new Customer("Charan", "Kumar", "charan@gmail.com", "9012345678", "Mumbai");

            // Create accounts
            SavingsAccount acc1 = new SavingsAccount(1001,"Deposit",2100,cust1,4.5);
            SavingsAccount acc2 = new SavingsAccount(1002, "Savings", 6000, cust2, 4.5);
            //SavingsAccount acc3 = new SavingsAccount(1003, "Savings", 7000,cust2, 4.5);
            SavingsAccount accDuplicate = new SavingsAccount(1001, "Savings", 5000, cust1, 4.5);

            // 1. List - Sort by Customer Name
            List<Account> accountList = new List<Account> { acc1, acc2 };
            accountList.Sort((a, b) => string.Compare(a.Customer.CustomerName, b.Customer.CustomerName));
            Console.WriteLine("\nList sorted by customer name:");
            foreach (var acc in accountList)
                acc.PrintAccountInfo();

            // 2. HashSet - Avoid Duplicates
            HashSet<Account> accountSet = new HashSet<Account>();
            accountSet.Add(acc1);
            accountSet.Add(acc2);
            accountSet.Add(accDuplicate); // 
            Console.WriteLine("\nHashSet accounts (no duplicates):");
            foreach (var acc in accountSet)
                acc.PrintAccountInfo();

            // 3. Dictionary - Key: AccountNumber
            Dictionary<long, Account> accountMap = new Dictionary<long, Account>();
            accountMap[acc1.AccountNumber] = acc1;
            accountMap[acc2.AccountNumber] = acc2;

            Console.WriteLine("\nAccess from Dictionary using account number:");
            if (accountMap.ContainsKey(1001))
                accountMap[1001].PrintAccountInfo();
        }
        
    }
}

