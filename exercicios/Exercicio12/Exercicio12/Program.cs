namespace Exercicio12;

class Program
{
    public static void Main()
    {
        Conversao obj = new();
        Console.WriteLine(obj.RealDolar(50));
        Console.WriteLine(obj.RealLibra(50));
        Console.WriteLine(obj.LibraReal(50));
        Console.WriteLine(obj.RealEuro(50));
        Console.WriteLine(obj.EuroReal(50));
        Console.WriteLine(obj.DolarReal(50));
    }
}
