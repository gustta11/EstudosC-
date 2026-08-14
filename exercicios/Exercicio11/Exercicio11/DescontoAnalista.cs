using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio11
{
    class DescontoAnalista:DescontoPadrao
    {
        public double DescontoValeTransporte(double salario)
        {
            double desconto = salario * 0.12;
            return desconto;
        }
    }
}
