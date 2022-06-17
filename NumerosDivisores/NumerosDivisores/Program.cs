using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um algoritmo em C# que exiba na tela todos os números de 1 até 10000 que são divisíveis por 5 e por 9.

namespace NumerosDivisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For irá percorrer de 1 até 10000 para o valor dos dividendos
            for (int i=1; i<=10000; i++)
            {
                /* Realizacao do teste, para verificar se o número (i) é divisível por 5 e por 9
                Utiliza % para calcular o resto da divisao
                i%5 ==> Verifica se é divisível por 5, logo o resto precisa ser 0
                i%9 ==> Verifica se é divisível por 9, logo o resto precisa ser 0

                */

                if (i%5==0 && i%9==0)
                {
                    //Caso o número seja divisível por 5 e 9, entao mostra na tela
                    Console.WriteLine(i);
                }
            }
            //Aguarda que alguma tecla seja pressionada
            Console.ReadKey();
        }
    }
}
