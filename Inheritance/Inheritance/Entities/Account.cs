using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    //Parent class (or base class)
    class Account
    {
        //Automatic Properties are used when no additional logic is required in the property accessors
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //We create a virtual method in the base class using the virtual keyword and that method is
        //overriden in the derived class using the override keyword.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
