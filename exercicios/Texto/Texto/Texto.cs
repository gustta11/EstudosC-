using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio17
{
    class Texto
    {
        private string _texto;

        public Texto(string txt)
        {
            _texto = txt;
            Console.WriteLine(contarCaracteres(_texto));
            Console.WriteLine(contarEspacos(_texto));
            Console.WriteLine(contarNumeros(_texto));
        }



        int contarCaracteres(string texto) // Desconsidera espacos
        {
            int totalCaracteres = 0;

            foreach (char c in texto)
            {
                if (!char.IsWhiteSpace(c))
                {
                    totalCaracteres++;
                }
            }
            return totalCaracteres;
        }


        int contarEspacos(string texto)
        {
            int totalEspacos = 0;

            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    totalEspacos++;
                }
            }
            return totalEspacos;
        }

        int contarNumeros(string texto)
        {
            int contarNumeros = 0;

            foreach (char c in texto)
            {
                if (char.IsNumber(c))
                {
                    contarNumeros++;
                }
            }

            return contarNumeros;

        }
    }

}
