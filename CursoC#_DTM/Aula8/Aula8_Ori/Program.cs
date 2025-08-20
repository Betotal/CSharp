using Aula8.Interfaces;
using Aula8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    class Program
    {
        private static void Main(string[] args)
        {

            IPessoaService service = new PessoaService();

            var todas = service.LerArquivo("D:\\Jose.Roberto\\CursoC#_DTM\\pessoas.txt");

            Console.WriteLine("Lista pessoas:");
            foreach (var pessoa in todas)
            {
                Console.WriteLine($"{pessoa.NomeGet} - {pessoa.IdadeGet} anos - {pessoa.GeneroGet}");
            }

            Console.WriteLine("Maiores de idade");
            foreach (var pessoa in service.FiltrarPorIdade(21,todas))
            {
                Console.WriteLine($"{pessoa.NomeGet} - {pessoa.IdadeGet} anos - {pessoa.GeneroGet}");
            }

            Console.ReadKey();
        }
    }
}
