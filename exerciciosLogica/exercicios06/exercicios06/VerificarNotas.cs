using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios06
{
    class VerificarNotas
    {
        public string VerificarSituacao(double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                return "Aprovado";
            }
            else if (media >= 5 && media <= 6.9)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
