using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio12
{
    public abstract class PadraoConversao
    {
        public abstract double DolarReal(double valor);
        public abstract double RealDolar(double valor);
        public abstract double EuroReal(double valor);
        public abstract double RealEuro(double valor);
        public abstract double LibraReal(double valor);
        public abstract double RealLibra(double valor);
    }
}
