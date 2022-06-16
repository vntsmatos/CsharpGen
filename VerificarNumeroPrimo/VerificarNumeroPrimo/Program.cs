using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escreva um algoritmo em C# que receba um número e verifique se este é um número primo

namespace VerificarNumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisores = 0;

            //Solicita que o usuário informe um número
            Console.WriteLine("Informe o número: ");

            //Realiza a leitura do número
            numero = Convert.ToInt32(Console.ReadLine());

            //Verificar a quantidade de divisores do número
            for (int i = 1; i <= numero; i++)
            {
                //Verifica se é divisor
                if (numero % i == 0)
                    divisores++;
            }

            //Depois de contar a quantidade de divisores, verifica se possui apenas 2
            //Observacao: um número é primo se possui apenas dois divisores ==> 1 e o próprio número
            if (divisores == 2)
                Console.WriteLine("É um número primo!");
            else
                Console.WriteLine("Não é um número primo!");

            //Aguarda que uma tecla seja pressionada
            Console.ReadKey();

        }
    }
}
