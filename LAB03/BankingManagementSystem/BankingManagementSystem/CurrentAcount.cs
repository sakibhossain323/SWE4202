using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class CurrentAcount : BankAccount
    {
        public CurrentAcount(int accountNumber, string accountHolderName, string branchName, double initialDeposit) : base(accountNumber, accountHolderName, branchName, initialDeposit)
        {
            AccountType = "Current";
        }
    }
}
