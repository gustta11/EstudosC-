namespace Exercicio14;

class Programm
{
    public static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 4, 4, 15, 16, 15 };

        Console.WriteLine(Numeros.Somar(list));
        Console.WriteLine(Numeros.Maior(list));
        Console.WriteLine(Numeros.Menor(list));
        foreach(int i in Numeros.SemRepeticao(list))
        {
            Console.WriteLine(i);
        }
       
    }
}
