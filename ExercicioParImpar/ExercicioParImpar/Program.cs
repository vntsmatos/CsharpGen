using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desenvolva um algoritmo em C# que solicite a entrada de um número e calcule se o número é par ou impar.

namespace ExercicioParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Por favor digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Para verificar se é par ou impar basta analisar se é ddivisível por 2
            //Se for divisível por 2 ==> É par
            //Se não for divisível por 2 ==> Não é par
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }

            //Aguarda que uma tecla seja pressionada
            Console.ReadKey();
        }
    }
}
