using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio11
{
    class DescontoDesenvolvedor:DescontoPadrao
    {
        public double DescontoValeTransporte(double salario)
        {
            double desconto = salario * 0.08;
            return desconto;
        }
    }
}
