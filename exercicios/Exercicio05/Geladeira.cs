using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Geladeira:Produto
    {
        private int _capacidadeArmazenamento;

        public Geladeira(string nome, string marca, double valor, int capacidadeArmazenamento)
        {
            Nome = nome;
            Marca = marca;
            Valor = valor;
            _capacidadeArmazenamento = capacidadeArmazenamento;
            Exibir();
            ExibirAtributo();
        }
        private void ExibirAtributo()
        {
            Console.WriteLine($"Capacidade de Armazenamento:{ _capacidadeArmazenamento}");
        }
    }
}
