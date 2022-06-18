using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desenvolva um algoritmo em C# que receba um número qualquer e apresente na tela o resultado da soma
de todos os algarismos deste número. Por exemplo: 12345 = 1+2+3+4+5 = 15
*/

namespace ExercicioSomarDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criacao das variaveis
            int numero;
            int digito;
            int soma = 0;

            //Mostrar uma mensagem para o usuario
            Console.WriteLine("Informe o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Estrutura de repeticao
            while (numero > 0)
            {
                digito = numero % 10; //Ultimo digito
                soma = soma + digito;
                numero = numero / 10;

            }
            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();

        }
    }
}
