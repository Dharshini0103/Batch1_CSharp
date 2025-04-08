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
using Assignment_Banking_System;
using static Assignment_Banking_System.CustomExceptionClass;

namespace service
{
    // Task 11 – Q5: Interface for customer services
    public interface ICustomerServiceProvider
    {
        float GetAccountBalance(long accountNumber); // Returns balance
        float Deposit(long accountNumber, float amount); // Returns new balance
        float Withdraw(long accountNumber, float amount); // Withdraw and return new balance
        void Transfer(long fromAccountNumber, long toAccountNumber, float amount); // Transfers amount
        void GetAccountDetails(long accountNumber); // Prints account and customer details
    }

    // Task 11 – Q6: Interface for bank services
public interface IBankServiceProvider
    {
        void CreateAccount(Customer customer, long accountnumber, string accType, float balance); // Create new account
        float Deposit(long accountNumber, float amount); // Deposit money
        float Withdraw(long accountNumber, float amount); // Withdraw money
        float GetAccountBalance(long accountNumber); // Balance check
        void Transfer(long fromAccountNumber, long toAccountNumber, float amount); // Transfer money
        void GetAccountDetails(long accountNumber); // Get account details
        void ListAccounts(); // Show all accounts
        void CalculateInterest(); // Calculate interest for savings accounts
    }

    // Task 11 – Q6: CustomerServiceProviderImpl implements ICustomerServiceProvider
    public class CustomerServiceProviderImpl : ICustomerServiceProvider
    {
        public static List<Account> accountList = new List<Account>();

        public Account FindAccount(long accNo)
        {
            return accountList.FirstOrDefault(acc => acc.AccountNumber == accNo);
        }

        public void AddAccount(Account account)
        {
            accountList.Add(account);
        }

        public List<Account> GetAllAccounts()
        {
            return accountList;
        }

        public float GetAccountBalance(long accountNumber)
        {
            Account acc = FindAccount(accountNumber);
            if (acc != null)
                return (float)acc.AccountBalance;

            Console.WriteLine("Account not found.");
            return 0;
        }

        public float Deposit(long accountNumber, float amount)
        {
            Account acc = FindAccount(accountNumber);
            if (acc != null)
            {
                acc.AccountBalance += amount;
                return (float)acc.AccountBalance;
            }

            Console.WriteLine("Account not found.");
            return 0;
        }

        public float Withdraw(long accountNumber, float amount)
        {
            Account acc = FindAccount(accountNumber);
            if (acc == null)
                throw new InvalidAccountException("Invalid Account Number.");

            if (acc is SavingsAccount savingsAcc)
            {
                if (savingsAcc.AccountBalance - amount < savingsAcc.AccountBalance)
                    throw new InsufficientFundException("Minimum balance must be maintained.");
            }
            else if (acc is CurrentAccount currentAcc)
            {
                if (currentAcc.AccountBalance + currentAcc.OverdraftLimit < amount)
                    throw new OverDraftLimitExceededException("Overdraft limit exceeded.");
            }
            else
            {
                if (acc.AccountBalance < amount)
                    throw new InsufficientFundException("Insufficient funds.");
            }

            acc.AccountBalance -= amount;
            return (float)acc.AccountBalance;
        }

        public void Transfer(long fromAcc, long toAcc, float amount)
        {
            var from = FindAccount(fromAcc);
            var to = FindAccount(toAcc);

            if (from == null || to == null)
                throw new InvalidAccountException("Invalid account(s).");

            if (from.AccountBalance < amount)
                throw new InsufficientFundException("Insufficient funds for transfer.");

            from.AccountBalance -= amount;
            to.AccountBalance += amount;
        }

        public void GetAccountDetails(long accountNumber)
        {
            Account acc = FindAccount(accountNumber);
            if (acc != null)
            {
                acc.Customer.PrintCustomerInfo();
                Console.WriteLine($"Account Number: {acc.AccountNumber}");
                Console.WriteLine($"Account Type: {acc.AccountType}");
                Console.WriteLine($"Balance: {acc.AccountBalance}");
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }
    // Task 11 – Q7: BankServiceProviderImpl extends CustomerServiceProviderImpl and implements IBankServiceProvider
    public class BankServiceProviderImpl : CustomerServiceProviderImpl, IBankServiceProvider
    {
        private string branchName;
        private string branchAddress;

        public BankServiceProviderImpl(string branchName = "Default Branch", string branchAddress = "Main Street")
        {
            this.branchName = branchName;
            this.branchAddress = branchAddress;
        }

        public void CreateAccount(Customer customer, long accNo, string accType, float balance)
        {
            Account newAccount = null;

            switch (accType.ToLower())
            {
                case "savings":
                    newAccount = new SavingsAccount(accNo, customer, balance);
                    break;
                case "current":
                    newAccount = new CurrentAccount(accNo, customer, balance);
                    break;
                case "zero":
                    newAccount = new ZeroBalanceAccount(customer);
                    break;
                default:
                    Console.WriteLine("Invalid account type.");
                    return;
            }

            AddAccount(newAccount);
            Console.WriteLine("Account created successfully.");
        }

        public void ListAccounts()
        {
            if (accountList.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            foreach (var acc in accountList.OrderBy(a => a.Customer.CustomerName))
            {
                acc.PrintAccountInfo();
            }
        }

        public void CalculateInterest()
        {
            foreach (var acc in accountList)
            {
                if (acc is SavingsAccount savings)
                {
                    float interest = (float)(savings.AccountBalance * savings.interestRate / 100);
                    savings.AccountBalance += interest;
                    Console.WriteLine($"Interest {interest} added to Account {savings.AccountNumber}");
                }
            }
        }
    }
}
