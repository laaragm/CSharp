using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Lara");
            list.Add("Harry");
            list.Add("Jord");
            list.Add("Dani");
            list.Insert(1, "Lorena");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();

            //A lambda expression is a convenient way of defining an anonymous (unnamed) function that
            //can be passed around as a variable or as a parameter to a method call.
            string s1 = list.Find(x => x[0] == 'L');
            Console.WriteLine("First 'L': " + s1);

            string s2 = list.FindLast(x => x[0] == 'L');
            Console.WriteLine("Last 'L': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'L');
            Console.WriteLine("First position 'L': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("Last position 'L': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'J');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
