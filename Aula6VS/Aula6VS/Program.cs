using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int valor = 0;  

            for(int i = 0; i<20; i++)//Intrução for para abraçar a instrução
            {
 //Precisa passar um instrução de inicio para for
                                   //i++ para percorrer de 1 até 19

            Console.WriteLine("Entre com o valor que deseja somar: ");
            valor += int.Parse(Console.ReadLine());  // leu o valor de inteiro
                                                     //+= é o valor 'mais' o que tem dentro do ReadLine

            }      
            Console.WriteLine$""


        }

             
    }
}
