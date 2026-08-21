namespace exercicios10;

class Program
{
    public static void Main()
    {
        Numeros n = new Numeros();
        Numeros n1 = new Numeros();

        Console.WriteLine(n.WithinInterval(10, 1, 10));
        Console.WriteLine(n1.WithinInterval(12, 1, 10));


    }
}
