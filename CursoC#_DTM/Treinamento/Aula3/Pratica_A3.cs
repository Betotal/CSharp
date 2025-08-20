using System;

namespace Aula3
{
    public class Pratica_A3_Modulo
    {
        public static void NumeroPorRef(int numero)
        {
            numero = 5;
            Dobrar(ref numero);
        }

        private static void Dobrar(ref int numero)
        {
            Console.Write($"O dobro de {numero} é: ");
            numero *= 2;
            Console.WriteLine(numero);
        }

        public static String ClassificaIdade(int idade)
        {
            if (idade >= 65)
            {
                return "idoso";
            }
            else if (idade >= 30)
            {
                return "Adulto";
            }
            else if (idade >= 18)
            {
                return "Jovem";
            }
            else if (idade >= 12)
            {
                return "Adolescente";
            }
            else
            {
                return "Criança";
            }
        }

        public static void Tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        public static void ImprimeArray(ref int[] array)
        {
            foreach (int itemArray in array)
            {
                Console.WriteLine($"número: {itemArray}");

            }
        }

    }
}
