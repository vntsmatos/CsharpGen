using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExList8.src
{
    internal class Pessoa
    {
        //Abrindo a variavel...
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Etinia { get; set; }
        public string Nome { get; set; }
        public string Signo { get; set; }

        public Pessoa(int _peso, double _altura, string _etnia, string _nome, string _signo)//Fazendo referêncai a String
        {
            Peso = _peso;
            Altura = _altura;
            Etinia = _etnia;// IBGE - Preta, Branca, Amarela, Parda, Indigena e Não Declarada
            Nome = _nome;
            Signo = _signo;


        }


        public void Acao(string andar)//Para pessoa 1
        {
            Console.WriteLine($"a ação que estou fazendo é {andar}");

        }

        public void Come(string come)//Para pessoa 2
        {
            Console.WriteLine($"Estou comendo {come}");
        }

        public void Dorme(string dorme)// Para pessoa 3
        {
            Console.WriteLine($"Dormindo zzzzz {dorme}");
        }

        public void Sofre(string sofre)// Para pessoa 4
        {
            Console.WriteLine($"A vida  não é só alegria, negocie seu alugel! {sofre}");
        }

        public void Previsao(string previsao)//Para pessoa 5
        {
            Console.WriteLine($"Hoje pessoas do seu signo podem ganhar na TELESENA...{previsao}");
        }

    }
}
