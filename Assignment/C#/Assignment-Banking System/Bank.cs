using System;
using bean;
//using service;
using AbstractAccount = bean.Account;
using SavingsAcc = bean.SavingsAccount;
using CurrentAcc = bean.CurrentAccount;

namespace app;

internal class Bank
{
    private static long nextAccountNumber = 1001;
    private AbstractAccount[] accounts = new AbstractAccount[100];
    private int accountCount = 0;
    private double overdraftLimit;

    // ----------------- Task 9: Create Account (Inheritance & Polymorphism) -----------------
    public void CreateAccountWithMenu()
    {
        Console.WriteLine("Choose Account Type to Create:");
        Console.WriteLine("1. Savings Account");
        Console.WriteLine("2. Current Account");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Email Address: ");
        string email = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string phone = Console.ReadLine();

        Customer customer = new Customer(firstName, lastName, email, phone, address);

        Console.Write("Enter Initial Balance: ");
        float balance = float.Parse(Console.ReadLine());

        long accNo = nextAccountNumber++;
        AbstractAccount newAccount = null;

        switch (choice)
        {
            case 1:
                Console.Write("Enter Interest Rate: ");
                double interest = double.Parse(Console.ReadLine());
                newAccount = new SavingsAcc(balance,customer,interest);
                break;

            case 2:
                newAccount = new CurrentAcc(balance,customer, overdraftLimit);
                break;

            default:
                Console.WriteLine("Invalid account type.");
                return;
        }

        if (newAccount != null)
        {
            AddManualAccount(newAccount);
            Console.WriteLine($"Account created successfully. Account Number: {accNo}");
        }
    }

    // ----------------- Task 10: Has-A Relationship - Find Account -----------------
    public AbstractAccount FindAccount(long accountNumber)
    {
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i].AccountNumber == accountNumber)
                return accounts[i];
        }
        return null;
    }

    // ----------------- Task 10: Get Account by number -----------------
    public AbstractAccount GetAccount(long accountNumber) => FindAccount(accountNumber);

    // ----------------- Task 10: Get Account Balance -----------------
    public double GetAccountBalance(long accountNumber)
    {
        var acc = FindAccount(accountNumber);
        if (acc != null) return acc.AccountBalance;

        Console.WriteLine(" Account not found.");
        return -1;
    }

    public AbstractAccount GetAccountByIndex(int index)
    {
        if (index >= 0 && index < accountCount)
            return accounts[index];
        return null;
    }

    // ----------------- Task 7, 8, 9: Deposit -----------------
    public double Deposit(long accountNumber, float amount)
    {
        var acc = FindAccount(accountNumber);
        if (acc != null)
        {
            acc.Deposit(amount);
            return acc.AccountBalance;
        }
        Console.WriteLine(" Account not found.");
        return -1;
    }

    // ----------------- Task 7, 8, 9: Withdraw -----------------
    public double Withdraw(long accountNumber, float amount)
    {
        var acc = FindAccount(accountNumber);
        if (acc != null)
        {
            acc.Withdraw(amount);
            return acc.AccountBalance;
        }
        Console.WriteLine(" Account not found.");
        return -1;
    }

    // ----------------- Task 7: Calculate Interest -----------------
    public void CalculateInterest(long accountNumber)
    {
        var acc = FindAccount(accountNumber);
        if (acc == null)
        {
            Console.WriteLine(" Account not found.");
            return;
        }

        if (acc is SavingsAcc savings)
        {
            savings.CalculateInterest();
        }
        else
        {
            Console.WriteLine(" Interest not applicable for current account.");
        }
    }

    // ----------------- Task 8 & 10: Transfer -----------------
    public void Transfer(long fromAccNo, long toAccNo, float amount)
    {
        var from = FindAccount(fromAccNo);
        var to = FindAccount(toAccNo);

        if (from == null || to == null)
        {
            Console.WriteLine(" One or both accounts not found.");
            return;
        }

        double overdraftLimit = (from is CurrentAcc) ? 10000 : 0;

        if ((from.AccountBalance + overdraftLimit) >= amount)
        {
            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine(" Transfer successful.");
        }
        else
        {
            Console.WriteLine(" Insufficient balance.");
        }
    }

    // ----------------- Task 10: Print Account Details -----------------
    public void GetAccountDetails(long accountNumber)
    {
        var acc = FindAccount(accountNumber);
        if (acc != null)
        {
            acc.PrintAccountInfo();
        }
        else
        {
            Console.WriteLine(" Account not found.");
        }
    }

 
    public void AddManualAccount(AbstractAccount account)
    {
        accounts[accountCount++] = account;
    }
}
