using System;
using System.Collections.Generic;
using System.Text;

namespace PooAbstract
{
    abstract class Acoes
    {
        // Metodos obrigatorios

        public abstract void Falar();

        public abstract void Olhar();

        public void Pular()
        {
            Console.WriteLine("Estou pulando neste momento");
        }
    }
}
