using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio16
{
    class PagamentoConsultor : Ipagamento
    {
        public double CalcularPagamento(double valor)
        {
            return valor + 200;
        }
    }
}
