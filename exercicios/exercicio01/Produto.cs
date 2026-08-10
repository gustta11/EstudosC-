using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio01
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor {  get; set; }
        public string FormaPagamento {  get; set; }

        public void RetornarCaracteristicas()
        {
            double valorProduto = Valor >= 500 && FormaPagamento == "À vista" ? Valor - (Valor * 0.10) : Valor;

            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Valor:{valorProduto}");
            Console.WriteLine($"Forma de pagamento:{FormaPagamento}");
            
        }


    }
}
