namespace exercicios08;

class Program
{
    public static void Main()
    {
        Triangulo t = new();
        Triangulo t2 = new();
        Console.WriteLine(t.IsTriangulo(3, 4, 5));
        Console.WriteLine(t2.IsTriangulo(1, 2, 5));     

    }
}
