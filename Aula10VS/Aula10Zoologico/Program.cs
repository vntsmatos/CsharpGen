using System;
using System.Collections.Generic;
using Aula10Zoologico.src;

namespace Aula10Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Baleia("Baleia Bey", "Cinza", 10),
                    new Baleia("Baleia Beyzinha", "Cinza", 8),
                    new Capivara("Capivara Venicio", "Preto", 10),
                    new Capivara("Capivara Pandora", "Branca", 8),
                    new Onca("Onça Felicia", "Branco",10 ),
                    new Onca("Onça Concita", "Branco",8 ),
                    
                }
            );
             foreach (Animal animal in animais)
            {
                if (animal.Tamanho == 10)
                {
                    Console.WriteLine($"{animal.Nome} tem um tamanho: {animal.Tamanho} ");
                    animal.Comunicar("olá, meu tamanho´é 10, sou enooooorme!");
                }
                else if (animal.Tamanho == 8)
                {
                    Console.WriteLine($"{animal.Nome} tem um tamanho: {animal.Tamanho} ");
                    animal.Comunicar("olá, meu tamanho´é 8, sou menorzinho!");


        }
    }
}