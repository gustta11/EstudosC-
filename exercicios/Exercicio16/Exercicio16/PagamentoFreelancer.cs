using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio16
{
    class PagamentoFreelancer : Ipagamento
    {
        public double CalcularPagamento(double valor)
        {
            double bonus = valor * 0.15;
            return valor + bonus;
        }
    }
}
