using System;
using Composition2.Entities;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {

            Post p1 = new Post(
                    DateTime.Parse("17/05/2020 12:20:15"), //date
                    "Traveling to Iceland", //title
                    "Can't wait to visit this wonderful country!", //content
                    12); //likes
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Enjoy!");
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                    DateTime.Now,
                    "Tv Shows",
                    "I need to find a new tv show",
                    5);
            Comment c3 = new Comment("I'm pretty sure you'll love Game of Thrones");
            Comment c4 = new Comment("You should study C# lol");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
