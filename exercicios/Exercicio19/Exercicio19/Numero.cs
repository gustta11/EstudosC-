using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio19
{
    class Numero
    {
        public Numero()
        {
            verifiacao();
        }

        private void verifiacao()
        {
            int numeroInformado;
            List<int> listaNumeros = new List<int>();
            do
            {
                Console.WriteLine("Informe um numero");
                numeroInformado = int.Parse(Console.ReadLine());
                if(numeroInformado == 0)
                {
                    break;
                }
                listaNumeros.Add(numeroInformado);
                Console.WriteLine($"A soma dos numeros informados:{soma(listaNumeros)}");
                Console.WriteLine($"A media dos numeros informados:{media(listaNumeros)}");
                Console.WriteLine($"Quantidade de numeros maiores que a media:{quantidadeMaiorQueMedia(listaNumeros)}");
                Console.WriteLine($"Quantidade de numeros multiplos de dois:{quantidadeMultiploDeDois(listaNumeros)}");


            } while (numeroInformado != 0);
        }

        private int soma(List<int> numeros)
        {
            int total = 0;

            foreach (int item in numeros)
            {
                total += item;
            }

            return total;
        }

        private double media(List<int> numeros)
        {
            return numeros.Average();
        }

        private int quantidadeMaiorQueMedia(List<int> numeros)
        {
            int qtd = 0;
            double numerosMedia = media(numeros);

            foreach(int item in numeros)
            {
                if(item > numerosMedia)
                {
                    qtd++;
                }
            }

            return qtd;        
        }

        private int quantidadeMultiploDeDois(List<int> numeros)
        {
            int qtd = 0;
            foreach(int item in numeros)
            {
                if (item % 2 == 0)
                {
                    qtd++;
                }
            }

            return qtd;
        }


    }
}
