using System;
using System.Collections.Generic;
using System.Text;

namespace PooHeranca
{
    class Cachorro : Animal
    {
        private string _raca;

        public Cachorro(string nome, int idade, int peso, string raca):base(nome,idade,peso)
        {
      
            _raca = raca;

            apresentarAnimal();
            apresentarCachorro();
        } 


        public void apresentarCachorro()
        {
            Console.WriteLine($"Raca{_raca}");
        }

        public override void  Som()
        {
            Console.WriteLine("AUAUAUAU");
        }


    }
}
