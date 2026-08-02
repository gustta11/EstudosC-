using System;
using System.Collections.Generic;
using System.Text;

namespace AulaPoo;

public class Carro
{
    public string modelo;
    public string marca;
    public int ano;
    public string cor;

    public void Ligar()
    {
        Console.WriteLine($"{this.modelo} ligado");
    }


}

