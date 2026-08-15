namespace Exercicio15;

class Program
{
    public static void Main()
    {
        Comissao obj = new Comissao();
        Comissao obj1 = new ComissaoDiretor();
        Comissao obj2 = new ComissaoGerente();
        Comissao obj3 = new ComissaoVendedor();

        Console.WriteLine(obj.CalcularComissao(1000));
        Console.WriteLine(obj1.CalcularComissao(1000));
        Console.WriteLine(obj2.CalcularComissao(1000));
        Console.WriteLine(obj3.CalcularComissao(1000));
    }
}