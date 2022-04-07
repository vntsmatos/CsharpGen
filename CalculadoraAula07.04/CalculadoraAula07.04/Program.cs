using System;

namespace CalculadoraAula07._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Digite o operador: ");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo Numero: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado:  { Somar(num1, num2)}"); //Colchetes é a interpolação
                    break;
                case " - ":
                    Console.WriteLine($"Resultado:  { Subtrair(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado:  { Multiplicar(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"Resultado:  { Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Operador Invalido");
                    break;


            }



        }
        public static string Somar(int num1, int num2) // Metodo para fazer a chamada
        {
            return (num1 + num2).ToString();
        }
        public static string Subtrair(int num1, int num2)
            // manipulador de acesso, manipulador de retorno e um manipulador string (acho que é isso)
            //Da explicação do Boaz
        {
            return (num1 - num2).ToString();
        }
        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string Dividir(int num1, int num2)
        {

            return (num1 / num2).ToString();

          
        }

    }
}
