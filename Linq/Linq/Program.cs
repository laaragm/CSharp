using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
	class Program
	{
		static void Main(string[] args)
		{
			//Delegates: É uma referência (com type safety) para um ou mais métodos. É um tipo referência.
			//Usos comuns: Comunicação entre objetos de forma flexível e extensível(eventos / callbacks),
			//Parametrização de operações por métodos(programação funcional)
			//Pré-definidos: Action, Func, Predicate

			List<Product> products = new List<Product>();

			products.Add(new Product("TV", 1500.0));
			products.Add(new Product("Mac Mini", 7000.0));
			products.Add(new Product("IPhone X", 3500.0));
			products.Add(new Product("Notebook", 2500.0));
			products.Add(new Product("Kindle", 300.0));

			//A função "Select" (LINQ) é uma função que aplica uma função a todos elementos de uma coleção, 
			//gerando assim uma nova coleção(do tipo IEnumerable).
			List<string> result = products.Select(p => p.Name.ToLower()).ToList(); 
			foreach (string product in result)
			{
				Console.WriteLine(product);
			}

			var a = from p in products
					where p.Price > 1500.0
					select p;
			Console.WriteLine();
			foreach (var product in a.ToList())
			{
				Console.WriteLine(product.Name + " " + product.Price);
			}


			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			IEnumerable<int> ans = numbers.Select(x => 2 * x);
			Console.WriteLine();
			Console.WriteLine(string.Join(" ", ans));

			var res = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
			Console.WriteLine();
			Console.WriteLine(string.Join(" ", res));

			var answer = res.Aggregate((x, y) => x + y);
			Console.WriteLine();
			Console.WriteLine(string.Join(" ", answer));
		}
	}
}
