using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desenvolver um algoritmo em C# que solicite a entrada da idade de um determinado usuário, se for menor
 * que 18 anos exiba na cor vermelha a mensagem "Acesso Negado!", caso seja maior ou igual a 18 anos exiba
 * na cor verde "Acesso Permitido!". 
 */

namespace VerificarIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variável para receber a idade do usuário
            int idade;

            //Exibe uma mensagem solicitando que o usuário informe a idade
            Console.WriteLine("Por favor sua idade: ");

            //Realiza a leitura da idade informada
            idade = Convert.ToInt32(Console.ReadLine());

            //Realiza os testes para analisar a idade informada
            if (idade >= 18)
            {
                //Altera a cor de fundo do texto no console para verde
                Console.BackgroundColor = ConsoleColor.Green;
                //Exibe a mensagem na tela
                Console.WriteLine("Acesso Permitido!");
            }
            else
            {
                //Altera a cor de fundo do console para vermelho
                Console.BackgroundColor = ConsoleColor.Red;
                //Exibe a mensagem na tela
                Console.WriteLine("Acesso Negado!");

            }

            //Aguarda que uma tecla seja pressionada
            Console.ReadKey();
        }
    }
}
