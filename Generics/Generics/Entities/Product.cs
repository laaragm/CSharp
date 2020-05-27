using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Generics.Entities
{
	class Product : IComparable
	{
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: Argument is not a Product");
            }
            Product anotherObject = obj as Product; //downcasting

            return Price.CompareTo(anotherObject.Price);
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
