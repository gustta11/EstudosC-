namespace exercicios09;

class Program
{
    public static void Main()
    {
        Triangulo t = new Triangulo();
        Triangulo t2 = new Triangulo();
        Triangulo t3 = new Triangulo();

        Console.WriteLine(t.TipoTriangulo(2, 2, 2));
        Console.WriteLine(t2.TipoTriangulo(2,1,2));
        Console.WriteLine(t3.TipoTriangulo(1, 4, 5));
    }
}
