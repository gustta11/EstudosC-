using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio07
{
    class Conversor : Padrao
    {
        public override void DolarReal(double dolar)
        {
            double cotacaoAtual = 5.17;
            double valorConvertido = dolar * cotacaoAtual;
            Console.WriteLine($"{dolar} Dólares em reais é R${valorConvertido}");
        }

        public override void RealDolar(double real)
        {
            double cotacaoAtual = 5.17;
            double valorConvertido = real / cotacaoAtual;
            Console.WriteLine($"{real} Reais em Dólares é ${valorConvertido:N2}");
        }
    }
}
