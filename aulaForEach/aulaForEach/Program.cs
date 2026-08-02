namespace aulaForEach;

public class Program
{
    public static void Main()
    {
        List<string> stringList = new List<string>() { "Jaqueline", "Gustavo", "Rafaela" };
        

        foreach (string str in stringList)
        {
            if (str == "Gustavo")
            {
                Console.WriteLine(stringList.IndexOf("Gustavo"));
            } else if (str == "Jaqueline")
            {
                Console.WriteLine("Noiva de Gustavo");
            }
            else
            {
                Console.WriteLine(str);
            }

        }
    }
}
