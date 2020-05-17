using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank
{
    class Account 
    {
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

        public override string ToString()
        {
            return "Account: " + Number + ", Owner: "
                + Owner + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
