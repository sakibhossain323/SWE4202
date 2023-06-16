using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class BankingSystem
    {
        public List<BankAccount> Accounts { get; } = new List<BankAccount>();

        public void CreateAccount(int accountNumber, string accountHolderName, string branchName, string accountType, double initialDeposit)
        {
            if (accountType == "Savings")
            {
                SavingsAccount acc = new SavingsAccount(accountNumber, accountHolderName, branchName, initialDeposit);
                Accounts.Add(acc);
            }
            else if (accountType == "Current")
            {
                CurrentAcount acc = new CurrentAcount(accountNumber, accountHolderName, branchName, initialDeposit);
                Accounts.Add(acc);
            }
            else throw new InvalidAccountTypeException();
        }

        public BankAccount FindAccount(int accountNumber)
        {
            foreach(BankAccount acc in Accounts)
            {
                if (accountNumber == acc.AccountNumber) return acc;
            }
            throw new AccountNotFoundException();
        }
    }
}
