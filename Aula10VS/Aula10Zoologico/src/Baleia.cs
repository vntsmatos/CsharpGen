using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10Zoologico.src
{
    public class Baleia : Animal
    {
        public Baleia() { }
        public Baleia(string nome, string cor, int tamanho) : base(nome, cor, tamanho) { }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está bufando: {comunicacao}");//Coloquei o som e a Onomatopeia
        }
    }
}
