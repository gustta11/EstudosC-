namespace aula02;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Informe seu sexo M ou F");
        int num = Convert.ToInt32 (Console.ReadLine());

        switch (num)
        {
            case 1:
            case 3:
                Console.WriteLine("Gustavo");
                break;
            case 2:
                Console.WriteLine("Jaqueline");
                break;
        }
        
    }

}
