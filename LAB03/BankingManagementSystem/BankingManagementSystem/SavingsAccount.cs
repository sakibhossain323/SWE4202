using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, string accountHolderName, string branchName, double initialDeposit) : base(accountNumber, accountHolderName, branchName, initialDeposit)
        {
            AccountType = "Savings";
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount*1.025);
        }
    }
}
