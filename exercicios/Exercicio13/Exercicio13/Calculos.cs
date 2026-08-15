using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio13
{
     class Calculos
    {
        public static void ContarVogais(string texto)
        {
            int totalVogais = 0;

            foreach (char c in texto)
            {

                if ("aeiouAEIOU".Contains(c))
                {
                    totalVogais++;
                }
            }

            Console.WriteLine(totalVogais);
        }

        public static void ContarConsoantes(string texto)
        {
            int totalConsoantes = 0;

            foreach (char c in texto)
            {
            
                if (!"aeiouAEIOU".Contains(c))
                {
                    totalConsoantes++;
                }
   
            }

            Console.WriteLine(totalConsoantes);
        }

        public static void EhPolindromo(string texto)
        {
            ReadOnlySpan<char> span = texto.ToLower().AsSpan();

            int esquerda = 0;
            int direita = span.Length - 1;

            while(esquerda < direita)
            {
                if (span[esquerda] != span[direita])
                {
                    Console.WriteLine("Nao e polindromo");
                    break;
                }

                esquerda++;
                direita--;   
            }
            Console.WriteLine("E polindromo");
        }
    }
}
