using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio12
{
    class Conversao : PadraoConversao
    {
        public override double DolarReal(double valor)
        {
            return valor * 5.50;
        }

        public override double EuroReal(double valor)
        {
            return valor * 6.40;
        }

        public override double LibraReal(double valor)
        {
            return valor * 7.40;
        }

        public override double RealDolar(double valor)
        {
            return valor / 5.50;
        }

        public override double RealEuro(double valor)
        {
            return valor / 6.40;
        }

        public override double RealLibra(double valor)
        {
            return valor / 7.40;
        }
    }
}
