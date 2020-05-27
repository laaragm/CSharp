using Generics.Entities;
using Generics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
            List<Product> products = new List<Product>();

            Console.Write("Number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] p = Console.ReadLine().Split(',');
                double price = double.Parse(p[1], CultureInfo.InvariantCulture);
                products.Add(new Product(p[0], price));
            }

            ProductCalculator calculationService = new ProductCalculator();

            Product product = calculationService.Max(products);

            Console.WriteLine();
            Console.Write("The most expensive item is: ");
            Console.WriteLine(product);
        }
	}
}
