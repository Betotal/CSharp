using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Pratica_A1
    {
        enum cargo
        {
            Gerente = 1,
            Analista,
            Tecnico,
            Estagiario
        }

        public static void Primeira()
        {
            Console.Write("Por favor, digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ola " + nome + ", voce tem " + idade + " anos e seu salário é R$ " + salario.ToString("F2"));
        }

        public static void HorasTrabalhadas()
        {
            Console.WriteLine("Bom dia.");
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Informe a quantidade de horas trabalhadas: ");
            int horasTrabalhadasNoMes = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor da hora: ");
            double valorHoraTrabalhada = double.Parse(Console.ReadLine());

            double valorBruto = horasTrabalhadasNoMes * valorHoraTrabalhada;

            Console.WriteLine();
            Console.WriteLine($"Ola {nomeFuncionario}");
            Console.WriteLine($"Com {horasTrabalhadasNoMes} horas trabalhadas no mes e valor da hora {valorHoraTrabalhada:F2}");
            Console.WriteLine($"seu salário bruto será: R${valorBruto:F2}");

        }

        public static void EnumCargo()
        {
            Console.WriteLine("Bom dia.");
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o seu salário: ");
            double salarioFunc = double.Parse(Console.ReadLine());

            Console.Write("Selecione o cargo:");
            Console.Write(" 1 - Gerente\n 2 - Analista\n 3 - Tecnico\n 4 - Estagiário");
            cargo cargoSelecionado = (cargo)int.Parse(Console.ReadLine());

            Console.WriteLine("Ola " + nomeFuncionario +
                              ", sua idade é: " + idade +
                              ", seu salário é " + salarioFunc.ToString("F2") +
                              " e seu cargo é " + cargoSelecionado);
            Console.WriteLine($"Interpolação - Ola {nomeFuncionario}, sua idade é: {idade}, seu salário é {salarioFunc.ToString("F2")} e seu cargo é {cargoSelecionado}");
        }

    }
}
