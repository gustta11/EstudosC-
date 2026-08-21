namespace exercicios01;

class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }
}
