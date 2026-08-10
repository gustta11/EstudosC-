using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio03
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        public Pessoa(string nome, int idade, string cidade)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;

            Mensagem();
        }

        private void Mensagem()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos e mora em {Cidade}");
        }
    }
}
