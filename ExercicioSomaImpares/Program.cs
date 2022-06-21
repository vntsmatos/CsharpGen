using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e 
 * que se encontram no conjunto dos números de 1 até 500. 
 */

namespace ExercicioSomaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0; //Incializar a variavel soma. Funciona como um 'acumulador de valores'
            for (int numero = 1; numero <= 500; numero++)
                //For para percorrer todo o intervalo entre os numeros
            {
                //Uso da condicional para ver se o numero é ímpar

                if (numero % 2 != 0 )//verifica a divisibilidade do numero por dois
                {
                    // É divisível por 3
                    if (numero % 3 == 0)
                    {
                        soma = soma + numero;
                    }
                }
            }
            Console.WriteLine(String.Format("O resultado da soma é: {0}`\n", soma));
            Console.Write("Pressione alguma tecla!");
            Console.ReadKey();
        }
    }
}
