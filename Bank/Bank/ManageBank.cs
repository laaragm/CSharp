using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank
{
    class ManageBank
    {
        public ManageBank()
        {

        }

        public void Manage()
        {
            Account account;
            Operations accOperations;

            Console.WriteLine("Welcome!");
            Console.Write("Account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Account owner: ");
            string owner = Console.ReadLine();
            Console.Write("Would you like to make an initial deposit (y/n)? ");
            char ans = char.Parse(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                Console.Write("Amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, owner, initialDeposit);
            }
            else
            {
                account = new Account(number, owner);
            }
            accOperations = new Operations(account);

            Console.WriteLine();
            Console.WriteLine("Account info:");
            Console.WriteLine(account);

            bool exit = false;
            int option;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Available Operations");
                Console.WriteLine("1- Deposit");
                Console.WriteLine("2- Withdraw (R$5.00 tax)");
                Console.WriteLine("3- Exit");
                Console.Write("What would you like to do today?");
                option = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (option == 3)
                {
                    exit = true;
                }
                else if (option == 2)
                {
                    Console.WriteLine();
                    Console.Write("Withdraw amount: ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    accOperations.Withdraw(amount);
                    Console.WriteLine("Acc info after withdraw:");
                    Console.WriteLine(accOperations);
                }
                else if (option == 1)
                {
                    Console.WriteLine();
                    Console.Write("Deposit amount: ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    accOperations.Deposit(amount);
                    Console.WriteLine("Acc info after deposit:");
                    Console.WriteLine(accOperations);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. Try again.");
                }

            }
        }
    }
}
