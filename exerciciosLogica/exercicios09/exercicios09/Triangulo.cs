using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios09
{
    class Triangulo
    {
        public string TipoTriangulo (int lado1, int lado2, int lado3)
        {
            if(lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }else if(lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                return "Isóceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
