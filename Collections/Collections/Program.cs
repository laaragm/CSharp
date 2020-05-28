using System;
using System.Collections.Generic;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			//SortedSet: armazenado em árvore; Inserção, remoção e busca: O(log(n))
			//Elementos armazenados ordenadamente conforme implementação IComparer<T>
			SortedSet<int> a = new SortedSet<int>() { 0, 1, 2, 4, 5, 6, 8, 10 };
			SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10, 11 };

			Console.WriteLine("SortedSet: ");
			SortedSet<int> c = new SortedSet<int>(a);
			c.UnionWith(b);
			PrintCollection(c);

			SortedSet<int> d = new SortedSet<int>(a);
			d.IntersectWith(b);
			PrintCollection(d);

			SortedSet<int> e = new SortedSet<int>(a);
			e.ExceptWith(b);
			PrintCollection(e);

			//HashSet: Armazenamento em tabela hash; Inserção, remoção e busca: O(1)
			//A ordem dos elementos não é garantida
			HashSet<int> f = new HashSet<int> { 0, 1, 2, 4, 5, 6, 8, 10 };
			HashSet<int> g = new HashSet<int> { 5, 6, 7, 8, 9, 10, 11 };

			Console.WriteLine();
			Console.WriteLine("HashSet: ");
			HashSet<int> h = new HashSet<int>(f);
			h.UnionWith(g);
			PrintCollection(h);

			HashSet<int> i = new HashSet<int>(f);
			i.IntersectWith(g);
			PrintCollection(i);

			HashSet<int> j = new HashSet<int>(f);
			j.ExceptWith(g);
			PrintCollection(j);
		}

		//IEnumerable: Expõe um enumerador que dá suporte a uma iteração simples em uma coleção.
		//Parâmetros do tipo T: O tipo de objetos a serem enumerados.Este parâmetro de tipo é covariante.
		//Isso significa que é possível usar o tipo especificado ou qualquer tipo mais derivado.
		static void PrintCollection<T>(IEnumerable<T> collection)
		{
			foreach (T obj in collection)
			{
				Console.Write(obj + " ");
			}
			Console.WriteLine();
		}
	}
}
