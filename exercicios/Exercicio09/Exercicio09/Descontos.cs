using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio09
{
    class Descontos
    {
        public Descontos(double salario, Boolean aderePlanoSaude)
        {
           
            Console.WriteLine($"Desconto vale-transporte:{ValeTransporte(salario)}");
            Console.WriteLine($"Desconto INSS: {INSS(salario)}");
            Console.WriteLine($"Desconto Plano de Saúde:{PlanoSaude(salario, aderePlanoSaude)}");
            Console.WriteLine($"{salario - ValeTransporte(salario) - INSS(salario) - PlanoSaude(salario, aderePlanoSaude)}");
        }

        private double ValeTransporte(double valor)
        {
            return valor * 0.06;
        }

        private double INSS(double valor)
        {
           double inss = valor <= 1_500.00 ? valor * 0.05 : valor > 1_500.00 && valor <= 3_000.00 ? valor * 0.08 : valor * 0.11;
           return inss;
        }

        private double PlanoSaude(double valor, Boolean aderente)
        {
            double descontoPlanoSaude = aderente ? valor * 0.05 : valor;
            return descontoPlanoSaude;
        }
    }
}
