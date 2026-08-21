using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios08
{
    class Triangulo
    {
        public string IsTriangulo(int number1, int number2, int number3)
        {
            int soma1 = number1 + number2;
            
            

            if(soma1 > number3)
            {
                return "Válido";
            }
            else
            {
                return "Inválido";
            }
        }
    }
}
