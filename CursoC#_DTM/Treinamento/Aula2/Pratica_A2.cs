using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Pratica_A2
    {
        public static void DiasSemana()
        {
            Console.Clear();
            string dia;
            do
            {
                Console.Write("Selecione um número de 1 à 7 para o dia da semana (s para sair): ");
                dia = Console.ReadKey().ToString().ToUpper();
                switch (dia)
                {
                    case "1":
                        Console.WriteLine("Hoje é Domingo");
                        break;

                    case "2":
                        Console.WriteLine("Hoje é Segunda-feira");
                        break;

                    case "3":
                        Console.WriteLine("Hoje é Terça-feira");
                        break;

                    case "4":
                        Console.WriteLine("Hoje é Quarta-feira");
                        break;

                    case "5":
                        Console.WriteLine("Hoje é Quinta-feira");
                        break;

                    case "6":
                        Console.WriteLine("Hoje é Sexta-feira");
                        break;

                    case "7":
                        Console.WriteLine("Hoje é Sabado");
                        break;

                    default:
                        Console.WriteLine("Dia inválido");
                        break;
                }
            } while (dia != "S");

            Console.WriteLine("Final da execução");
            Console.ReadKey();

        }
        public static void Idade()
        {
            Console.Clear();
            Console.Write("Digite o seu nome: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (idade >= 65)
            {
                Console.WriteLine($"{nomeFuncionario} é idoso.");
            }
            else if (idade >= 30)
            {
                Console.WriteLine($"{nomeFuncionario} é Adulto!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine($"{nomeFuncionario} é Jovem!");
            }
            else if (idade >= 12)
            {
                Console.WriteLine($"{nomeFuncionario} é Adolescente!");
            }
            else
            {
                Console.WriteLine($"{nomeFuncionario} é uma criança!");
            }
            Console.WriteLine("Final da execução");
            Console.ReadKey();
        }

        public static void Tabuada()
        {
            Console.Clear();
            int screenCol = 3;
            Console.SetCursorPosition(screenCol, 1);
            Console.WriteLine("Usando FOR...");
            Console.SetCursorPosition(screenCol, 2);
            Console.Write("Digite um numero: ");
            int numTabuada = int.Parse(Console.ReadLine());

            int i = 0;
            int resultado;

            for (i = 0; i < 10; i++)
            {
                resultado = numTabuada * (i + 1);
                Console.SetCursorPosition(screenCol, i + 3);
                Console.WriteLine($"{ numTabuada} x {i + 1} = {resultado}");
            }

            screenCol = 33;
            Console.SetCursorPosition(screenCol, 1);
            Console.WriteLine("Usando WHILE...");
            Console.SetCursorPosition(screenCol, 2);
            Console.Write("Digite um numero: ");
            numTabuada = int.Parse(Console.ReadLine());

            i = 1;
            while (i <= 10)
            {
                resultado = numTabuada * i++;
                Console.SetCursorPosition(screenCol, i + 1);
                Console.WriteLine($"{ numTabuada} x {i - 1} = {resultado}");
            }

            screenCol = 63;
            Console.SetCursorPosition(screenCol, 1);
            Console.WriteLine("Usando DO... WHILE");
            Console.SetCursorPosition(screenCol, 2);
            Console.Write("Digite um numero: ");
            numTabuada = int.Parse(Console.ReadLine());

            i = 1;
            do
            {
                resultado = numTabuada * i++;
                Console.SetCursorPosition(screenCol, i + 1);
                Console.WriteLine($"{ numTabuada} x {i - 1} = {resultado}");
            } while (i <= 10);

            Console.WriteLine("Final da execução");
            Console.ReadKey();
        }

        public static void clientes()
        {
            Console.Clear();
            Console.WriteLine("Programa para listas os valores de uma lista pre-determinada");

            string[] clientes = { "IsringHausen", "Cheques Cardápio", "La Serenissima", "Cavo", "Irmãos Parasmo", "Datamace" };

            Console.WriteLine("\nLista de empresa que já trabalhei\n");
            foreach (var empresa in clientes)
            {
                Console.WriteLine($"Bem vindo, {empresa}");
            }
            Console.ReadKey();
        }

        public static void NotasTurma()
        {
            Console.Clear();
            Console.WriteLine("Programa para lançamento de notas\n");

            Console.Write("Informe a quantidade de alunos: ");
            int qtdeAlunos = int.Parse(Console.ReadLine());

            double[] notaAlunos = new double[qtdeAlunos];

            for (int i = 0; i < qtdeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notaAlunos[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            double media = 0;
            double maiorNota = 0.0;
            double menorNota = 10.0;
            foreach (var notaAluno in notaAlunos)
            {
                media += notaAluno;
                if (notaAluno >= maiorNota) maiorNota = notaAluno;
                if (notaAluno <= menorNota) menorNota = notaAluno;
            }

            media /= qtdeAlunos;

            Console.WriteLine($"A média da turma é : {media:F2}");
            Console.WriteLine($"A maior nota foi: {maiorNota:F2}");
            Console.WriteLine($"A menor nota foi: {menorNota:F2}\n\n");

            string mensagem = (media < 5) ? "Ruim" : (media >= 7)? "Bom":"Regular";
            Console.WriteLine($"Desempenho da turma: {media:F2} - {mensagem}");
            
            string resposta;
            do
            {
                Console.Write("\nDeseja relatório detalhado: ");
                resposta = Console.ReadLine().ToUpper();
            } while (resposta != "S" && resposta != "N");
            
            if (resposta == "S")
            {
                int num = 0;
                foreach (var notaAluno in notaAlunos)
                {
                    num++;
                    Console.WriteLine($"Aluno {num} - Nota: {notaAluno:F2}");
                }
            }
            Console.WriteLine("Final da execução");
            Console.ReadKey();
        }        
    }
}
