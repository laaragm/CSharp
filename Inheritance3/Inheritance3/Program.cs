using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance3.Entities;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Lara", 1000.00, 0.02));
            list.Add(new BusinessAccount(1002, "Cont", 1000.0, 2000.0));
            list.Add(new SavingsAccount(1004, "Dani", 2000.0, 0.03));

            double sum = 0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //The Withdraw method is going to be executed using the Polymorphism concept
            foreach (Account acc in list)
            {
                acc.Withdraw(100.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
