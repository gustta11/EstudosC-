namespace exercicios05;

class Program
{
    public static void Main()
    {
        int age = int.Parse(Console.ReadLine());

        if(age >= 18)
        {
            Console.WriteLine("Pode votar");
        }
        else
        {
            Console.WriteLine("Não");
        }
    }
}
