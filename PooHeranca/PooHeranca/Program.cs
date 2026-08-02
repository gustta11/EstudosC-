namespace PooHeranca;

public class Program
{
    public static void Main()
    {
        Cachorro pet = new Cachorro("Vaqueiro", 5, 15, "Salsicha");
        Animal obj2 = new Cachorro("Mimosa", 6, 16, "Budog");
        Animal obj3 = new Gato("margo", 3, 14);

        obj3.Som();

        obj2.Som();

    }

}
