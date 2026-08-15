using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Produto
    {
        protected string? Nome;
        protected string? Marca;
        protected double? Valor;

        protected void Exibir()
        {
            //string valor = Valor?.ToString("0.000") ?? "";
            Console.WriteLine($"Nome do produto:{Nome}");
            Console.WriteLine($"Marca do produto:{Marca}");
            Console.WriteLine($"Valor do produto:{Valor:C0}");
        }
    }
}
