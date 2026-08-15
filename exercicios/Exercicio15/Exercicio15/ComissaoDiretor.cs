using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio15
{
    internal class ComissaoDiretor:Comissao
    {
        public override double CalcularComissao(double valorVenda)
        {
            return valorVenda * 0.10;
        }
    }
}
