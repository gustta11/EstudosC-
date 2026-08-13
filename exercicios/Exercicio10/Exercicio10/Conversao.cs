using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10
{
    class Conversao
    {
        private double _valor;
        public Conversao(double valor, string tipoConversao)
        {
            _valor = valor;
            double conversao = tipoConversao == "selsiusFahrenheit" ? SelsiusFahrenheit() : tipoConversao == "fahrenheitselsius" ? FahrenheitSelsius() : 0;
            Console.WriteLine(conversao);
        }
        private double SelsiusFahrenheit()
        {
            return (_valor * 1.8) + 32;
        }

        private double FahrenheitSelsius()
        {
            return (_valor - 32) / 1.8;
        }
    }
}
