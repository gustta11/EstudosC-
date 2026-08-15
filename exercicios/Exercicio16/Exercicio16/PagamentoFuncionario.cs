using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio16
{
    class PagamentoFuncionario : Ipagamento
    {
        public double CalcularPagamento(double valor)
        {
            double desconto = valor * 0.10;
            return valor - desconto;
        }
    }
}
