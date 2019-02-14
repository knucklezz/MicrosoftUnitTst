using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftUnitTest
{
    public class Account
    {
        private decimal _balance { get; set; }

        public void Deposit(decimal value)
        {
            if (value >= 0)
            {
                _balance = _balance + value;
            }
        }

        public void Withdraw(decimal value)
        {
            if (value >= 0 && value <= _balance)
            {
                _balance = _balance - value;
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void TransferFunds(Account SendAccount, Account ReceiveAccount, decimal value)
        {
            if (value >= SendAccount._balance)
            {
                SendAccount.Withdraw(value);
                ReceiveAccount.Deposit(value);
            }
        }
    }
}
