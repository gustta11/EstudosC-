using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    class Moeda : Inotas, Imoedas
    {
        public Moeda(int nota, int moeda)
        {

            Console.WriteLine($"{ContarNotas200(nota)} notas de 200");
            Console.WriteLine($"{ContarNotas100(nota)} notas de 100");
            Console.WriteLine($"{ContarNotas50(nota)} notas de 50");
            Console.WriteLine($"{ContarNotas20(nota)} notas de 20");
            Console.WriteLine($"{ContarNotas10(nota)} notas de 10");
            Console.WriteLine($"{ContarNotas5(nota)} notas de 5");
            Console.WriteLine($"{ContarNotas2(nota)} notas de 2");
            Console.WriteLine("-----Moedas-----");
            Console.WriteLine($"{ContarMoedas1(moeda)} moedas de 1,00");
            Console.WriteLine($"{ContarMoedas50(moeda)} moedas de 0,50");
            Console.WriteLine($"{ContarMoedas25(moeda)} moedas de 0,25");
            Console.WriteLine($"{ContarMoedas10(moeda)} moedas de 0,10");
            Console.WriteLine($"{ContarMoedas5(moeda)} moedas de 0,05");


        }

        public int ContarMoedas1(int valor)
        {
            return valor / 100;

        }

        public int ContarMoedas10(int valor)
        {
            int restante = valor % 25;
            return restante / 10;
        }

        public int ContarMoedas25(int valor)
        {
            int restante = valor % 50;
            return restante / 25;
        }

        public int ContarMoedas5(int valor)
        {
            int restante = valor % 10;
            return restante / 5;
        }

        public int ContarMoedas50(int valor)
        {
            int restante = valor % 100;
            return restante / 50;
        }

        public int ContarNotas10(int valor)
        {
            int restante = valor % 20;
            return restante / 10;
        }

        public int ContarNotas100(int valor)
        {
            int restante = valor % 200;
            return restante / 100;
        }

        public int ContarNotas2(int valor)
        {
            int restante = valor % 5;
            return restante / 2;
        }

        public int ContarNotas20(int valor)
        {
            int restante = valor % 50;
            return restante / 20;
        }

        public int ContarNotas200(int valor)
        {
            return valor / 200;
        }

        public int ContarNotas5(int valor)
        {
            int restante = valor % 10;
            return restante / 5;
        }

        public int ContarNotas50(int valor)
        {
            int restante = valor % 100;
            return restante / 50;
        }
    }
}
