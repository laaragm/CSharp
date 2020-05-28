using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dateTime = new DateTime(2020, 05, 26, 11, 30, 55);
			Console.WriteLine(dateTime.ElapsedTime());

			string str = "I am studying C#";
			Console.WriteLine(str.Cut(7));
		}
	}
}
