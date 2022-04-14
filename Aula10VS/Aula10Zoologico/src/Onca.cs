using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10Zoologico.src
{
    public class Onca : Animal
    {
        public Onca() { }
        public Onca(string nome, string cor, int tamanho) : base(nome, cor, classificacao) { }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está rugindo: {comunicacao}"); //Coloquei o som e a Onomatopeia
        }
    }
}
