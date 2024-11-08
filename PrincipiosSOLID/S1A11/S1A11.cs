using System.Security.Cryptography;
//using Internal;

namespace S1A11;

public class Program_A11{
    static public void Main()  //  Main(string[] args) 
    {
        Console.Clear();
        Console.WriteLine("Modelo Anêmico Id: -1, Nome: <vazio>, Endereco: <vazio>");

        Console.WriteLine();
        ClienteAnemico cliAnemico = new();
        cliAnemico.Id = -1;
        cliAnemico.Nome = "";
        cliAnemico.Endereco = "";
        Console.WriteLine($"Id: {cliAnemico.Id}, nome: {cliAnemico.Nome}, endereço:{cliAnemico.Endereco} ");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Dominio Rico Id: -1, Nome: <vazio>, Endereco: <vazio>");
        Console.WriteLine();

        ClienteRico cliRico = new(-1, "", "");
        Console.WriteLine($"Id: {cliRico.Id}, nome: {cliRico.Nome}, endereço:{cliRico.Endereco} ");
        Console.ReadLine();
    }
}