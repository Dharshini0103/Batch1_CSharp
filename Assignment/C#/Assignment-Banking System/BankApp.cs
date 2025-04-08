using System;
using bean;
using service;

namespace app
{
    internal class BankApp
    {
        private static long accNo;
        private static string accType;

        public static void Bankapp()
        {
            IBankServiceProvider bankService = new BankServiceProviderImpl();

            while (true)
            {
                Console.WriteLine("\n--- Banking Menu ---");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Get Balance");
                Console.WriteLine("5. Transfer");
                Console.WriteLine("6. Get Account Details");
                Console.WriteLine("7. List Accounts");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n-- Create Account (Type 'exit' anytime to stop creating) --");
                        while (true)
                        {
                            Console.Write("Enter Customer Name (or 'exit' to stop): ");
                            string name = Console.ReadLine();
                            if (name.ToLower() == "exit") break;

                            Console.Write("Enter Customer Address: ");
                            string address = Console.ReadLine();

                            Customer customer = new Customer();

                            Console.Write("Choose Account Type (savings / current / zero): ");
                            string type = Console.ReadLine();
                            if (type.ToLower() == "exit") break;

                            Console.Write("Enter Initial Balance: ");
                            if (!float.TryParse(Console.ReadLine(), out float balance))
                            {
                                Console.WriteLine("Invalid balance input.");
                                break;
                            }

                            float extra = 0;
                            if (type.ToLower() == "savings" || type.ToLower() == "current")
                            {
                                Console.Write("Enter Interest Rate (for savings) or Overdraft Limit (for current): ");
                                if (!float.TryParse(Console.ReadLine(), out extra))
                                {
                                    Console.WriteLine("Invalid value.");
                                    break;
                                }
                            }

                            bankService.CreateAccount(customer, accNo,accType, balance);
                        }
                        break;

                    case "2":
                        Console.Write("\nEnter Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long depAccNo))
                        {
                            Console.WriteLine("Invalid account number.");
                            break;
                        }

                        Console.Write("Enter Amount to Deposit: ");
                        if (!float.TryParse(Console.ReadLine(), out float depAmt))
                        {
                            Console.WriteLine("Invalid amount.");
                            break;
                        }

                        float newBal = bankService.Deposit(depAccNo, depAmt);
                        Console.WriteLine($"New Balance: {newBal}");
                        break;

                    case "3":
                        Console.Write("\nEnter Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long withAccNo))
                        {
                            Console.WriteLine("Invalid account number.");
                            break;
                        }

                        Console.Write("Enter Amount to Withdraw: ");
                        if (!float.TryParse(Console.ReadLine(), out float withAmt))
                        {
                            Console.WriteLine("Invalid amount.");
                            break;
                        }

                        try
                        {
                            float bal = bankService.Withdraw(withAccNo, withAmt);
                            Console.WriteLine($"Remaining Balance: {bal}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        break;

                    case "4":
                        Console.Write("\nEnter Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long balAcc))
                        {
                            Console.WriteLine("Invalid account number.");
                            break;
                        }

                        float accBalance = bankService.GetAccountBalance(balAcc);
                        Console.WriteLine($"Account Balance: {accBalance}");
                        break;

                    case "5":
                        Console.Write("\nEnter Sender Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long fromAcc))
                        {
                            Console.WriteLine("Invalid sender account number.");
                            break;
                        }

                        Console.Write("Enter Receiver Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long toAcc))
                        {
                            Console.WriteLine("Invalid receiver account number.");
                            break;
                        }

                        Console.Write("Enter Amount to Transfer: ");
                        if (!float.TryParse(Console.ReadLine(), out float transferAmt))
                        {
                            Console.WriteLine("Invalid transfer amount.");
                            break;
                        }

                        try
                        {
                            bankService.Transfer(fromAcc, toAcc, transferAmt);
                            Console.WriteLine("Transfer Successful.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        break;

                    case "6":
                        Console.Write("\nEnter Account Number: ");
                        if (!long.TryParse(Console.ReadLine(), out long detAcc))
                        {
                            Console.WriteLine("Invalid account number.");
                            break;
                        }

                        bankService.GetAccountDetails(detAcc);
                        break;

                    case "7":
                        bankService.ListAccounts();
                        break;

                    case "8":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
