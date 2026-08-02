namespace arrayAula;

public class Program
{
    public static void Main()
    {
        string[] nomes = { "gustavo", "Jaqueline" };

        foreach (string n in nomes)
        {
            Console.WriteLine(n);
        }
        nomes[0] = "Julia";
        foreach (string n in nomes)
        {
            Console.WriteLine(n);
        }

        string[] frutas = new string[3];

        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine("Informe o nome de uma fruta");
            frutas[i] = Console.ReadLine();
        }

        foreach(string f in frutas)
        {
            Console.WriteLine(f);
        }
    }
}