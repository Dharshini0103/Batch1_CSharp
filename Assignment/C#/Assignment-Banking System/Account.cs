using System;
using static Assignment_Banking_System.CustomExceptionClass;

namespace bean
{
    // ---------------------------- Task 7 ----------------------------
    // Task 7 - Create a class ‘Account’ that includes the following attributes. Generate account number using static variable.
    // Attributes: Account Number (auto-generated), Account Type (e.g., Savings, Current), Account Balance, Customer
    public class Account
    {
        // Task 11 - Static variable to auto-generate unique account number
        private static long lastAccNo = 1000;

        public long accountNumber;
        public string accountType;
        public double accountBalance;
        public Customer customer;

        // Task 7 - Default constructor
        public Account()
        {
            accountNumber = ++lastAccNo; // Auto-increment
            accountType = "Not set";
            accountBalance = 0;
        }

        // Task 7 - Overloaded constructor with attributes
        public Account(string accountType, double accountBalance, Customer customer)
        {
            accountNumber = ++lastAccNo; // Auto-increment
            this.accountType = accountType;
            this.accountBalance = accountBalance;
            this.customer = customer;
        }

        // Task 7 - Getter and Setter Methods
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        // ---------------------------- Task 8 ----------------------------
        // Task 8 - Overloaded deposit methods
        public void Deposit(float amount)
        {
            accountBalance += amount;
            Console.WriteLine("Deposited (float): " + amount + " | New Balance: " + accountBalance);
        }

        public void Deposit(int amount)
        {
            accountBalance += amount;
            Console.WriteLine("Deposited (int): " + amount + " | New Balance: " + accountBalance);
        }

        public void Deposit(double amount)
        {
            accountBalance += amount;
            Console.WriteLine("Deposited (double): " + amount + " | New Balance: " + accountBalance);
        }

        // Task 8 - Overloaded withdraw methods
        public virtual void Withdraw(float amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
                Console.WriteLine("Withdrew (float): " + amount + " | Remaining Balance: " + accountBalance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public virtual void Withdraw(int amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
                Console.WriteLine("Withdrew (int): " + amount + " | Remaining Balance: " + accountBalance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
                Console.WriteLine("Withdrew (double): " + amount + " | Remaining Balance: " + accountBalance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        // ---------------------------- Task 9 ----------------------------
        // Task 9 - Method to calculate interest (default: 4.5%)
        public virtual void CalculateInterest()
        {
            double interest = accountBalance * 4.5 / 100;
            Console.WriteLine("Interest at 4.5%: " + interest);
        }

        // Task 9 - Method to print account information
        public void PrintAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Account Balance: " + accountBalance);
            Console.WriteLine("Customer Details:");
            customer.PrintCustomerInfo();
        }

        // ---------------------------- Task 13 ----------------------------
        // Task 13 - Override Equals() and GetHashCode() to support HashSet (avoid duplicates by AccountNumber)
        public override bool Equals(object obj)
        {
            Account other = obj as Account;
            if (other != null)
            {
                return this.accountNumber == other.accountNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return accountNumber.GetHashCode();
        }
    }

    // ---------------------------- Task 11 ----------------------------
    // Task 11 - SavingsAccount: Should include interest rate and enforce minimum balance of 500
    public class SavingsAccount : Account
    {
        public double interestRate;

        public SavingsAccount(double balance, Customer customer, double interestRate)
            : base("Savings", balance < 500 ? 500 : balance, customer) // Enforce min 500
        {
            this.interestRate = interestRate;
        }

        public SavingsAccount(long accNo, string accType, double balance, Customer customer, double interestRate)
            : base(accType, balance, customer)
        {
            this.accountNumber = accNo; // Manually set account number
            this.interestRate = interestRate;
        }

        public override void CalculateInterest()
        {
            double interest = AccountBalance * interestRate / 100;
            Console.WriteLine("Savings Account Interest: " + interest);
        }
    }

    // ---------------------------- Task 11 ----------------------------
    // Task 11 - CurrentAccount: Should include overdraft limit, and withdraw can exceed balance up to that limit
    public class CurrentAccount : Account
    {
        public double OverdraftLimit { get; set; }

        public CurrentAccount(double balance, Customer customer, double overdraftLimit)
            : base("Current", balance, customer)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (AccountBalance + OverdraftLimit >= amount)
            {
                AccountBalance -= amount;
                Console.WriteLine("Withdrew " + amount + " (Overdraft Allowed) | New Balance: " + AccountBalance);
            }
            else
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
        }
    }

    // ---------------------------- Task 11 ----------------------------
    // Task 11 - ZeroBalanceAccount: Can be created with 0 balance
    public class ZeroBalanceAccount : Account
    {
        public ZeroBalanceAccount(Customer customer)
            : base("ZeroBalance", 0, customer)
        {
            // Always starts with 0 balance
        }
    }
}
