namespace exercicios03;

class Program
{
    public static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());

        if(number1 < 0)
        {
            Console.WriteLine("Negativo");
        }else if (number1 > 0)
        {
            Console.WriteLine("Positivo");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}
