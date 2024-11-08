using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Desafios
{
    public class Codigo1While
    {
        public static void Codigo1_While(){

            Console.Clear();

            Console.WriteLine("Laço com validação de dados de entrada - Código 1");
            Console.WriteLine();
            int numero = 0;
            bool validaNumero = false;

            do
            {
                Console.Write("Por favor, informar um número entre 5 e 10: ");
                validaNumero = int.TryParse(Console.ReadLine(), out numero);

                if (!validaNumero || (validaNumero && (numero < 5 || numero > 10))){
                    Console.WriteLine($"Número informado: {numero} (inválido)");
                    Console.WriteLine();
                    validaNumero = false;
                }
            } while (!validaNumero);

            Console.WriteLine($"Número aceito: {numero}");
            Console.ReadLine();
        }
    }
}