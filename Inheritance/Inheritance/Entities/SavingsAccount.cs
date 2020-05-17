using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    //To inherit from a class, use the : symbol.
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        //base keyword is used to access fields, constructors and methods of base class.
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //base keyword can also be used to refer to the superclass implementation
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
