using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio14
{
    class Numeros
    {

        public static int Somar(List<int> numeros)
        {
            int soma = 0;

            foreach(int i in numeros)
            {
                soma += i;
            }

            return soma;
        }

        public static List<int> SemRepeticao(List<int> numeros)
        {
            List<int> numerosSemRepetir = new List<int>();

            foreach (int i in numeros)
            {
                if (!numerosSemRepetir.Contains(i))
                {
                    numerosSemRepetir.Add(i);
                }
            }

            return numerosSemRepetir;
        }

        public static int Maior(List<int> numeros)
        {
            return numeros.Max();
        }

        public static int Menor(List<int> numeros)
        {
            return numeros.Min();
        }
    }
}
