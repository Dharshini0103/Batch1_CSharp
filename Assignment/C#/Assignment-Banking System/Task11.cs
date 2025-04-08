using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bean;
using app;
using service;

namespace Assignment_Banking_System;

internal class Task11
{
    public static void Task11Run()
    {
        Console.WriteLine("Task 11");
        BankApp.Bankapp();
        IBankServiceProvider bankService = new BankServiceProviderImpl();

        
        Customer customer = new Customer();
        long accountNumber = 1001;

        bankService.CreateAccount(customer, 1000, "savings",4.5f); 

       
        float balance = bankService.GetAccountBalance(accountNumber); 
        Console.WriteLine($"Balance for account is: {balance}");
    }
}

