namespace aula13;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
        }
    }
}

