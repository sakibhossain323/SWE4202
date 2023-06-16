using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class BankingSystemException : Exception
    {
        public BankingSystemException(string msg) : base(msg)
        {

        }
    }

    class InvalidAccountTypeException : BankingSystemException
    {
        public InvalidAccountTypeException() : base("Account type is not valid!")
        {

        }
    }

    class AccountNotFoundException : BankingSystemException
    {
        public AccountNotFoundException() : base("Account not found!")
        {

        }
    }

    class AccountSuspendedException : BankingSystemException
    {
        public AccountSuspendedException() : base("Account is suspended!")
        {

        }
    }

    class InvalidAmountException : BankingSystemException
    {
        public InvalidAmountException() : base("Invalid Amount!")
        {

        }
    }

    class InsufficientBalanceException : BankingSystemException
    {
        public InsufficientBalanceException() : base("Insufficient Balance!")
        {

        }
    }
}
