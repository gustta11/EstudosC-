using System;
using System.Collections.Generic;
using System.Text;

namespace PooHeranca
{
    class Gato : Animal
    {
        public Gato(string nome, int idade, int peso):base(nome, idade, peso)
        {
            apresentarAnimal();
        }
        public override void Som()
        {
            Console.WriteLine("Miauu");
        }
    }
}
