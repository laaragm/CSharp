using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não há repetição de elementos e estes não tem posições dentro do conjunto
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            Console.Write("Conjunto A:");
            foreach (int elem in A)
            {
                Console.Write(" " + elem);
            }

            Console.WriteLine();
            Console.Write("Conjunto B:");
            foreach (int elem in B)
            {
                Console.Write(" " + elem);
            }

            HashSet<int> copiaA = new HashSet<int>(A);
            HashSet<int> copiaB = new HashSet<int>(B);
            Console.WriteLine();
            Console.WriteLine("Operações com conjuntos: ");
            Console.Write("A-B: ");
            copiaA.ExceptWith(copiaB);
            foreach (int i in copiaA)
            {
                Console.Write(" " + i);
            }
                        
            Console.WriteLine();
            HashSet<int> copiaAA = new HashSet<int>(A);
            HashSet<int> copiaBB = new HashSet<int>(B);
            Console.Write("AUB: ");
            copiaAA.UnionWith(copiaBB);
            foreach (int i in copiaAA)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();
            Console.Write("A∩B: ");
            A.IntersectWith(B);
            foreach (int i in A)
            {
                Console.Write(" " + i);
            }

        }
    }
}
