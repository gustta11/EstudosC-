using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    internal interface Imoedas
    {
        int ContarMoedas1(int valor);
        int ContarMoedas50(int valor);
        int ContarMoedas25(int valor);
        int ContarMoedas10(int valor);
        int ContarMoedas5(int valor);
    }
}
