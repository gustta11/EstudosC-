using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios10
{
    class Numeros
    {
        public string WithinInterval(int numero, int numero1, int numero2)
        {
            if(numero >= numero1 && numero <= numero2)
            {
                return "Dentro do intervalo";
            }
            else
            {
                return "Fora do intervalo";
            }
        }
    }
}
