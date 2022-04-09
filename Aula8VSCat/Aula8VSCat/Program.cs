using System;

namespace Aula8VSCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gato garfild = new Gato("Garfild", "Laranja", 8);
            Gato tomas = new Gato("Thomas", "Cinza", 5);
            Gato frajola = new Gato();
            frajola.Nome = "Frajoja";
            frajola.Tamanho = 4;


            Console.WriteLine($"Gato 1 é o {garfild.Nome} de cor {garfild.Cor} e tem o tamanho {garfild.Tamanho}");
            Console.WriteLine($"Gato 1 é o {tomas.Nome} de cor {tomas.Cor} e tem o tamanho {tomas.Tamanho}");
            Console.WriteLine($"Gato 1 é o {frajola.Nome} de cor {frajola.Cor} e tem o tamanho {frajola.Tamanho}");

            garfild.comer("Lazanha");
            tomas.dormir();
            string retorno = frajola.ronronar();
            Console.WriteLine(retorno); 

        }
    }
}
