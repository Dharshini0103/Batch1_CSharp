using System;
using bean;
using service;
using static Assignment_Banking_System.CustomExceptionClass;

namespace Assignment_Banking_System
{
    internal class Task12
    {
        public static void Task12Run()
        {
            Console.WriteLine("Task 12");

            IBankServiceProvider bankService = new BankServiceProviderImpl();

            try
            {
                Customer cust1 = new Customer();
                bankService.CreateAccount(cust1, 1001, "savings", 1000);
                Account savingsAcc = null;
                Account currentAcc = null;

                foreach (Account acc in CustomerServiceProviderImpl.accountList)
                {
                    if (acc is SavingsAccount && savingsAcc == null)
                    {
                        savingsAcc = acc;
                    }
                    else if (acc is CurrentAccount && currentAcc == null)
                    {
                        currentAcc = acc;
                    }
                }

                try
                {
                    long invalidAcc = 999999;
                    ExceptionHandling.ValidateAccountNumber(invalidAcc);
                }
                catch (InvalidAccountException ex)
                {
                    Console.WriteLine("[InvalidAccountException] " + ex.Message);
                }

                try
                {
                    if (savingsAcc != null)
                    {
                        float withdrawAmount = 6000;
                        ExceptionHandling.CheckSufficientFunds(savingsAcc, withdrawAmount);
                    }
                }
                catch (InsufficientFundException ex)
                {
                    Console.WriteLine("[InsufficientFundException] " + ex.Message);
                }

                try
                {
                    if (currentAcc != null && currentAcc is CurrentAccount)
                    {
                        CurrentAccount curr = (CurrentAccount)currentAcc;
                        float overLimit = (float)(curr.AccountBalance + curr.OverdraftLimit + 100);
                        ExceptionHandling.CheckOverdraftLimit(curr, overLimit);
                    }
                }
                catch (OverDraftLimitExceededException ex)
                {
                    Console.WriteLine("[OverDraftLimitExceededException] " + ex.Message);
                }

                try
                {
                    string name = null;
                    Console.WriteLine(name.Length);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("[NullReferenceException] " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Unexpected Error] " + ex.Message);
            }
        }
    }
}
