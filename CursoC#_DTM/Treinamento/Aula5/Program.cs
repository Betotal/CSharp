using System;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Aula 5\n");

            Console.WriteLine("Aluno\n");
            Aluno aluno1 = new ();
            Aluno aluno2 = new ();

            aluno1.Nome = "Carlos Alberto";
            aluno1.Idade = 25;
            aluno1.NotaFinal = 7.5f;
            Console.WriteLine(aluno1.ExibirResumo());

            aluno2.Nome = "Pedro Bó";
            aluno2.Idade = -5;
            aluno2.NotaFinal = 11.9f;
            Console.WriteLine(aluno2.ExibirResumo());
            _ = Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Produto\n");
            Produto prod1 = new ();
            Produto prod2 = new ();

            prod1.NomeProd = "Caneta esferografica";
            prod1.PrecoProd = 52.5f;
            prod1.EstoqueProd = 10;
            Console.WriteLine(prod1.ExibirProduto());

            prod2.NomeProd = "Tarefa de casa";
            prod2.PrecoProd = 1.5f;
            prod2.EstoqueProd = -10;
            Console.WriteLine(prod2.ExibirProduto());

        }
    }
}
