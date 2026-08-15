using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio18
{
    class Randoms
    {

        public Randoms()
        {
            int numeroGerado = gerarNumero();
            conferencia(numeroGerado);
        }

        private int gerarNumero()
        {
            int num = Random.Shared.Next(1, 10);
            Console.WriteLine(num);
            return num;
        }

        private void conferencia(int numeroGerado)
        {
            int numero;

            do
            {
                Console.WriteLine("Informe um numero:");
                numero = int.Parse(Console.ReadLine());
                
            } while(numero != numeroGerado);

            Console.WriteLine("Numero encontrado");
        }
    }
}
