using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    abstract class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        public string BranchName { get; }
        public string AccountType { get; protected set; }
        public double Balance { get; protected set; }
        public bool IsSuspended { get; protected set; }

        public BankAccount(int accountNumber, string accountHolderName, string branchName, double initialDeposit)
        {

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            BranchName = branchName;
            Balance = initialDeposit;
            IsSuspended = false;
        }

        public virtual void Deposit(double amount)
        {
            if (IsSuspended) throw new AccountSuspendedException();
            if (amount <= 0) throw new InvalidAmountException();
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (IsSuspended) throw new AccountSuspendedException();
            if (amount > Balance) throw new InsufficientBalanceException();
            Balance -= amount;
        }

        public void Suspend()
        {
            IsSuspended = true;
        }
    }
}
