using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bean;
using service;

namespace Assignment_Banking_System
{
    internal class ExceptionHandling
    {
        public static void CheckSufficientFunds(Account account, float amount)
        {
            if (account is SavingsAccount)
            {
                const float minimumBalance = 500; 
                if (account.AccountBalance - amount < minimumBalance)
                    throw new CustomExceptionClass.InsufficientFundException("Withdrawal would violate minimum balance of 500.");
            }
            else
            {
                if (account.AccountBalance < amount)
                    throw new CustomExceptionClass.InsufficientFundException("Insufficient funds in account.");
            }
        }
        public static void ValidateAccountNumber(long accountNumber)
        {
            foreach (Account acc in CustomerServiceProviderImpl.accountList)
            {
                if (acc.AccountNumber == accountNumber)
                {
                    return;
                }
            }
            throw new CustomExceptionClass.InvalidAccountException("Invalid account number: " + accountNumber);
        }
        public static void CheckOverdraftLimit(CurrentAccount account, float amount)
        {
            if (account.AccountBalance + account.OverdraftLimit < amount)
            {
                throw new CustomExceptionClass.OverDraftLimitExceededException("Overdraft limit exceeded for account: " + account.AccountNumber);
            }
        }




    }
}
