using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Media
    {
        public Media(double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;

            Console.WriteLine($"A media do aluno: {media}");
        }

        public Media(double nota1, double nota2, double nota3)
        {
            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A media do aluno: {media}");
        }

    }
}
