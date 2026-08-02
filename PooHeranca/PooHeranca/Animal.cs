using System;
using System.Collections.Generic;
using System.Text;

namespace PooHeranca
{
    class Animal
    {
        private string _nome;
        private int _idade;
        private int _peso;

        public Animal(string nome, int idade, int peso)
        {
            _nome = nome;
            _idade = idade;
            _peso = peso;
        }

        protected void apresentarAnimal()
        {
            Console.WriteLine($"Nome:{_nome}");
            Console.WriteLine($"Idade:{_idade}");
            Console.WriteLine($"Peso:{_peso}");
        }

        public virtual void Som()
        {
            Console.WriteLine("Animal desconhecido...");
        }
    }
}
