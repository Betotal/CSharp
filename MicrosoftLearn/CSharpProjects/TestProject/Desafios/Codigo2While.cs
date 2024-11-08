using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Desafios
{
    public class Codigo2While
    {
        public static void Codigo2_While(){

            Console.Clear();

            Console.WriteLine("Laço com validação de dados de entrada - Código 2");
            Console.WriteLine();
            string entrada1, entrada;
            do
            {
                Console.Write("Por favor entre com uma das opções de acesso (Administrador, Gerente, Usuario): ");
                entrada = Console.ReadLine().Trim().ToLower();
                entrada1 = entrada;
                if (entrada != "administrador" && entrada != "gerente" && entrada != "usuario" && entrada != "")
                {
                    Console.WriteLine($"Valor de entrada \"{entrada1}\" é inválido.");
                    Console.WriteLine();
                }

            } while (entrada != "administrador" && entrada != "gerente" && entrada != "usuario" && entrada != "");

            Console.WriteLine($"Acesso para \"{entrada1}\" Validado. Proximo exercício");
            Console.ReadLine();


        }
    }
}