namespace aulaLists;

public class Program
{
    public static void Main()
    {
        List<string> fruits = new List<string>();

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Adicione uma fruta");
            fruits.Add(Console.ReadLine());
        }
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
