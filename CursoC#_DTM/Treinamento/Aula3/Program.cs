using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Aula 3");
            Console.Write("Informe um número para dobrar: ");
            int numero = int.Parse(Console.ReadLine());
            Pratica_A3_Modulo.NumeroPorRef(numero);
            Console.ReadKey();

            Console.Clear();
            Console.Write("Informe sua idade: ");
            Console.WriteLine($"Vocé é { Pratica_A3_Modulo.ClassificaIdade(int.Parse(Console.ReadLine()))}");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Exiba a tabuada do: ");
            Pratica_A3_Modulo.Tabuada(int.Parse(Console.ReadLine()));
            Console.ReadKey();

            Console.Clear();
            Console.Write("Agora usaremos Array. Quantos números voce deseja digitar: ");
            int qtdeNumeros = int.Parse(Console.ReadLine());
            int[] array = new int[qtdeNumeros];

            int indice = 0;
            do
            {   
                if (indice < qtdeNumeros)
                {
                    Console.Write("Digite o número: ");
                    array[indice++] = int.Parse(Console.ReadLine());
                }
            } while (indice < qtdeNumeros);

            Console.WriteLine("\nAgora exibiremos o(s) numero(s) digitado(s) \n");

            Pratica_A3_Modulo.ImprimeArray(ref array);
            Console.ReadKey();
        }
    }
}
