using System;
using System.Collections.Generic;
using System.Text;

namespace AulaConstructor
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Nenhum argumento");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine($"O nome dele {nome}");
        }

        public Pessoa(string nome, int idade)
        {
            Console.WriteLine($"O nome dele {nome} e idade {idade}");
        }

    }
}
