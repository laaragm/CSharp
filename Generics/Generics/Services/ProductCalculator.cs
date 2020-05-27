using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Services
{
	class ProductCalculator
	{
        //Os genéricos <T> introduzem o conceito de parâmetros de tipo ao .NET Framework, que 
        //possibilitam projetar classes e métodos que adiem a especificação de um ou mais tipos
        //até que a classe ou método seja declarado e instanciado pelo código do cliente.
        //IComparable: Define um método de comparação de tipo específico generalizado que 
        //implementa uma classe ou um tipo de valor para solicitar ou classificar suas instâncias.
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List cannot be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                //CompareTo: Compara a instância atual com outro objeto do mesmo tipo e retorna um
                //inteiro que indica se a instância atual precede, segue ou ocorre na mesma posição
                //da ordem de classificação do outro objeto.
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
