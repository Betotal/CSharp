using Aula8.Interfaces;
using Aula8.Services;
using System;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPessoaService service = new PessoaService();

            service.LerArquivo(@"D:\Jose.Roberto\CursoC#_DTM\pessoas.txt");
            Console.WriteLine("lista de Pesosas");
            foreach (var pessoa in service.PegarTodos())
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade} anos - {pessoa.Genero}");
            }

            Console.WriteLine("Maiores de idade (21+)");
            foreach (var pessoa in service.FiltrarPorIdade(21))
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade} anos - {pessoa.Genero}");
            }
        }
    }
}
