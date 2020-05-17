using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank
{
    class Operations 
    {
        private Account Account { get; set; }
        public Operations(Account account) 
        {
            Account = account;
        }

        public void Deposit(double val)
        {
            Account.Balance += val;
        }

        public void Withdraw(double val)
        {
            Account.Balance = Account.Balance - val - 5;
        }

        public override string ToString()
        {
            return "Account: " + Account.Number + ", Owner: "
                + Account.Owner + ", Balance: "
                + Account.Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
