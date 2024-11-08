// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

namespace S1A5;
public class Program_A5{
    static public void Main()  //  Main(string[] args) 
    { 
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Projeto Classe e método. Hello, World!");
        Console.WriteLine();

        Pessoa pessoa0 = new ("Jose", 50, "masculino");
        pessoa0.Identificar();
        Console.WriteLine();

        Pessoa pessoa1 = new();
        pessoa1.nome = "Paulo";
        pessoa1.idade = 45;
        pessoa1.genero = "masculino";
        pessoa1.Identificar();
        Console.WriteLine();

        Pessoa pessoa2 = new Pessoa();
        pessoa2.nome = "Pedro Bó";
        pessoa2.idade = 47;
        pessoa2.genero = "indefinido";
        Console.WriteLine($"Olá, sou o {pessoa2.nome}. Tenho {pessoa2.idade} anos e sou do sexo {pessoa2.genero} .");
        Console.ReadLine();

    }
}
