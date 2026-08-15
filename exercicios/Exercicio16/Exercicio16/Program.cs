namespace Exercicio16;

class Program
{
    public static void Main()
    {
        PagamentoConsultor obj = new PagamentoConsultor();
        PagamentoFreelancer obj1 = new PagamentoFreelancer();
        PagamentoFuncionario obj2 = new PagamentoFuncionario();

        Console.WriteLine(obj.CalcularPagamento(1000));
        Console.WriteLine(obj1.CalcularPagamento(1000));
        Console.WriteLine(obj2.CalcularPagamento(1000));

    }
}
