// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

namespace S1A7;
public class Program_A7{
    static public void Main()  //  Main(string[] args) 
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Uso da palavra \"this\". Hello, World!");
        Console.WriteLine();

        Exemplo exemplo1 = new Exemplo("Teste this");
        Console.ReadLine();
    }
}

class Teste{
    public string Nome { get; set; }

    public Teste(Exemplo exemplo1)
    {
        // usa o nome da instancia como parametro
        this.Nome = exemplo1.Nome;
        Console.WriteLine($"Teste: {this.Nome}");
    }
}

class Exemplo{
    public string Nome { get; set; }
    public Exemplo(string nome)
    {
        this.Nome = nome;        
        // Passa a instawcia "this" como um parâmetro
        Teste teste1 = new Teste(this);

        // A Instacia "Teste" agora possui o mesmo valor em "nome"
        Console.WriteLine($"Exemplo: {teste1.Nome}");
    }
}


