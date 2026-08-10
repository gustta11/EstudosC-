using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio02
{
    class Aluno
    {
        public string Nome { get; set; }
        public double nota1 { get; set; }
        public double nota2 {  get; set; }

        private double Media()
        {
            return (nota1 + nota2) / 2;
        }

        private Boolean Situacao() { 
            double media = Media();
            if(media >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Resultado()
        {
            double media = Media();
            Boolean resultado = Situacao();

            if(resultado == true)
            {
                Console.WriteLine($"Aluno {Nome} aprovado com média:{media}");
            }
            else
            {
                Console.WriteLine($"Aluno {Nome} reprovado com média:{media}");
            }
        }
    }
}
