namespace Exercicio11;

class Program
{
    public static void Main()
    {
        DescontoPadrao obj = new();
        DescontoDesenvolvedor obj2 = new();
        DescontoAnalista obj3 = new();

        Console.WriteLine($"O desconto padrão para o respectivo salário é: {obj.DescontoValeTransporte(5000)}");
        Console.WriteLine($"O desconto do desenvolvedor para o respectivo salário é: {obj2.DescontoValeTransporte(5000)}");
        Console.WriteLine($"O desconto Analista para o respectivo salário é: {obj3.DescontoValeTransporte(5000)}");
    }
}
