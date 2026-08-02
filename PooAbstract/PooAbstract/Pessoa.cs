using System;
using System.Collections.Generic;
using System.Text;

namespace PooAbstract
{
    class Pessoa : Acoes
    {
        public override void Falar()
        {
            Console.WriteLine("Estou falando");
        }

        public override void Olhar()
        {
            Console.WriteLine("Estou olhando");
        }
    }
}
