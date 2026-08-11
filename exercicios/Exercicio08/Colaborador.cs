using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio08
{
    class Colaborador : IDesconto, IBonus
    {

        public void ValeTrasporte(double salarioBruto)
        {
            double salarioComDesconto = salarioBruto - (salarioBruto * 0.06);
            Console.WriteLine($"O salário com desconto é: {salarioComDesconto}");
            Console.WriteLine($"O desconto será de R${salarioBruto * 0.06}");
        }

        public void PremioFaltas(int faltas)
        {
            Console.WriteLine(faltas == 0 ? "Ganhou bônus de R$300" : "Não ganhou bônus");
        } 
    }
}
