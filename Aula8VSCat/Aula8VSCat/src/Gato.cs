using System;

namespace Aula8VSCat;
{
    public class Gato
    {
    public string Nome { get; set; } // "get e set" GET: podemos acessar pelo nome e e SET: alterar o que está dentro dele
    public string Cor { get; set; }
    public int Tamanho { get; set; }

    public Gato()
    {

    }


    public Gato(string Nome, string Cor, int Tamanho)
    {
        Nome = nome;
        Cor = cor;
        Tamanho = tamanho;
    }

    public void dormir()
    {
        Console.WriteLine("zzzzzzzzzzzz..");

    }
    public void comer(string comida)
    {
        Console.WriteLine($"Estou comendo {comida}");
    }
    public string ronronar()
    {
        Console.WriteLine($"Estou comendo {comida}");



    }

    }
    
}



    //fim
