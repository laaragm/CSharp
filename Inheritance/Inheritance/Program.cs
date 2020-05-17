using Inheritance.Entities;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Lara", 1000.0);
            //Upcasting
            Account acc2 = new SavingsAccount(1002, "Dani", 2000.0, 0.01);
            BusinessAccount acc3 = new BusinessAccount(1003, "Lara", 10000.0, 50000.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);

        }
    }
}
