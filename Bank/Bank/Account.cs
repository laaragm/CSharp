using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    //Parent class (or base class)
    class Account 
    {
        private Account account;

        //Automatic Properties are used when no additional logic is required in the property accessors
        public int Number { get; set; }
        public string Owner {get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }
        public Account(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        //this keyword refers to the current instance of the class and is also used as a modifier of the first 
        //parameter of an extension method 
        public Account(int number, string owner, double balance) : this(number, owner)
        {
            Balance = balance;
        }

        public Account(Account account)
        {
            this.account = account;
        }
    }
}
