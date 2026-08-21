namespace exercicios02;

class Program
{
    public static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        if(number1 > number2)
        {
            Console.WriteLine(number1);
        }else if (number1 < number2)
        {
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine("Números iguais");
        }
    }
}
