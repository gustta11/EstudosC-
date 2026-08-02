namespace AulaPoo;

public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();
        Carro carro2 = new Carro();

        carro.ano = 2015;
        carro.modelo = "Palio atractive";
        carro.marca = "Fiat";
        carro.cor = "Prata";

        carro2.ano = 2016;
        carro2.modelo = "Punto";
        carro2.marca = "Fiat";
        carro2.cor = "Vermelha";

        List<Carro> listCarro = new List<Carro>();

        listCarro.Add(carro);
        listCarro.Add(carro2);

        foreach (Carro car in listCarro)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(car.ano);
            Console.WriteLine(car.modelo);
            Console.WriteLine(car.marca);
            Console.WriteLine(car.cor);
            car.Ligar();
        }
    }
}