using System;

namespace Aula07._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pessoa =ImprimeNome("Vinicius Santos");

            Console.WriteLine("Nome é : " + pessoa.Item2);
            Console.WriteLine("Tamanho do nome é : "+ pessoa.Item2);
            
        }
        public static (string, int) ImprimeNome(string nome = default)
        {
            return($"O nome é: {nome}",nome.Length);
        }
    }
}
