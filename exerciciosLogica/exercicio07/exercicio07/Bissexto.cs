using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio07
{
    class Bissexto
    {
        public string VerificacaoBissexto(int ano)
        {
            if(ano % 400 == 0)
            {
                return "Bissexto";
            }else if(ano % 100 == 0)
            {
                return "Não bissexto";
            }else if(ano % 4 == 0)
            {
                return "Bissexto";
            }
            else
            {
                return "Não bissexto";
            }
        }
    }
}
