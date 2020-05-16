using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank
{
    //To inherit from a class, use the : symbol.
    class Operations : Account
    {
        //base keyword is used to access fields, constructors and methods of base class.
        public Operations(int number, string owner, double balance) : base(number, owner, balance)
        {

        }

        public Operations(int number, string owner) : base(number, owner)
        {

        }

        public void Deposit(double val)
        {
            this.Balance += val;
        }

        public void Withdraw(double val)
        {
            this.Balance = this.Balance - val - 5;
        }

        public override string ToString()
        {
            return "Account: " + this.Number + ", Owner: " 
                + this.Owner + ", Balance: " 
                + this.Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
