using System;

namespace TabuadMalu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("TABUADA");
            Console.WriteLine(" Digite o número que você que multiplicar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = (numero * x);

                Console.WriteLine($"{numero} x {x} = {resultado}");
            }
        }
    }
}
