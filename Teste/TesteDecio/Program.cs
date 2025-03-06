using System;


namespace TesteDecio {
    class Program {
        static void Main(string[] args) {

            int a, b, soma;

            Console.Write("Digite o 1º número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Números digitado: {a} e {b} ");

            Console.WriteLine($"A soma dos números é: {soma = a + b} ");

            Console.ReadLine();
        }
    }
}