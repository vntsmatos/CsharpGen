using System;

namespace IMCVini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, IMC;
            string nome;

            Console.WriteLine("Entre com seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Entre com seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com sua altura");
            altura = float.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + IMC);//Aqui a gnt faz concatenacao para exibir o imc da pessoa

            if (IMC < 18.5)
            {
                Console.WriteLine("abaixo do peso:" + IMC);
            }
            else if (IMC < 25)
            {
                Console.WriteLine("peso normal:" + IMC);
            }
            else if (IMC < 30)
            {
                Console.WriteLine("sobre peso:" + IMC);

            }
            else
            {
                Console.WriteLine("obesidade:");
            }


        }
    }
}