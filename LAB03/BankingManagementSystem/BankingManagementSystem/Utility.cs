using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    static class Utility
    {
        public static int CountTotalAccounts(BankingSystem banksys)
        {
            return banksys.Accounts.Count;
        }

        public static int GetNextAccountNo(BankingSystem banksys)
        {
            return 1 + CountTotalAccounts(banksys);
        }

    }
}
