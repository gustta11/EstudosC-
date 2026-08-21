namespace exercicio07;

class Program
{
    public static void Main()
    {
        Bissexto ano = new Bissexto();
        Bissexto ano2 = new Bissexto();
        Bissexto ano3 = new Bissexto();

        Console.WriteLine(ano.VerificacaoBissexto(2024));
        Console.WriteLine(ano2.VerificacaoBissexto(1900));
        Console.WriteLine(ano3.VerificacaoBissexto(2000));
    }
}
