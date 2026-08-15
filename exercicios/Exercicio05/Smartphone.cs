using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Smartphone:Produto
    {
        private string _sistemaOperacional;

        public Smartphone(string nome, string marca, double valor,string sistemaOperacional)
        {
            Nome = nome;
            Marca = marca;
            Valor = valor;
            _sistemaOperacional = sistemaOperacional;
            Exibir();
            ExibirAtributo();
        }

        private void ExibirAtributo()
        {
            Console.WriteLine($"Sistema Operacional:{_sistemaOperacional}");
        }
    }
}
