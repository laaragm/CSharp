using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Entities
{
	public class Product
	{
		public string Name { get; }
		public double Price { get; }

		public Product()
		{
		}

		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
