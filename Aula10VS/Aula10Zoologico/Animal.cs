using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10Zoologico
{
    public class Animal
        //Atributos
    {
        public string Nome { get; set;  }
        public string Cor { get; set; }
        public string Tamanho { get; set; }

        public Animal() { }

        public Animal(string nome, string cor, string tamanho)
        {
            Nome = nome;
            Cor = cor;
            Tamanho = tamanho;
        }
        public virtual void Comunicar(string comunicacao)//incluindo mais um atributo de comunicação
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
    }
}
