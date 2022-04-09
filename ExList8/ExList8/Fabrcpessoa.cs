using ExList8.src;
using System;

namespace ExList8
{
    internal class Fabrcpessoa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("criacao pessoas...");
            //Os dados são para fins didaticos e não refletem a realidade...
            Pessoa Veniciu = new Pessoa("83", "1.75", "Preta", "Veniciu","Escorpião");
            Pessoa Jaiminho = new Pessoa("107", "1.68", "Branca", "Jaiminho", "Peixes");
            Pessoa Chiquinha = new Pessoa("52", "1,57", "Branca", "Chiquinha", "Aries");
            Pessoa Madruguinha = new Pessoa("64", "1.86", "Branca", "Madruguinha", "Virgem");
            Pessoa Florinda = new Pessoa("57", "1.66", "Branca", "Florinda", "Touro");

            Console.WriteLine($"pessoa 1 pesa {Veniciu.Peso} altura {Veniciu.Altura} etinia {Veniciu.Etinia} nome {Veniciu.Nome} seu signo é {Veniciu.Signo} ");
            Console.WriteLine($"pessoa 2 pesa {Jaiminho.Peso} altura {Jaiminho.Altura} etinia {Jaiminho.Etinia} nome {Jaiminho.Nome} seu signo é {Jaiminho.Signo} ");
            Console.WriteLine($"pessoa 3 pesa {Chiquinha.Peso} altura {Chiquinha.Altura} etinia {Chiquinha.Etinia} nome {Chiquinha.Nome} seu signo é {Chiquinha.Signo} ");
            Console.WriteLine($"pessoa 4 pesa {Madruguinha.Peso} altura {Madruguinha.Altura} etinia {Madruguinha.Etinia} nome {Madruguinha.Nome} seu signo é {Madruguinha.Signo} ");
            Console.WriteLine($"pessoa 5 pesa {Florinda.Peso} altura {Florinda.Altura} etinia {Florinda.Etinia} nome {Florinda.Nome} seu signo é {Florinda.Signo} ");

            Veniciu.Acao("Caminhando...");
            Jaiminho.Come();
            Chiquinha.Dorme("Arroz, Feijão e Fritas");
            Madruguinha.Sofre("Não pagou o aluguel!");
            Florinda.Previsao("Hoje pessoas do seu signo podem ganhar na TELESENA...");
        }


    }
}

