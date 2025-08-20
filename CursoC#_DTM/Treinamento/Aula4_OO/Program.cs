using System;

namespace Aula4_OO
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Aula 4\n");
            Console.WriteLine("Dados da pessoa 1:");
            Pessoa p1 = new Pessoa();
            p1.Nome = "Carlos";
            p1.Sobrenome = "Chagas";
            p1.Apelido = "Cacha";

            Console.WriteLine("\nDados da pessoa 2:");
            Pessoa p2 = new Pessoa();
            p2.Nome = "Pedro";
            p2.Sobrenome = "Bó";
            p2.Apelido = "Bó";

            Console.WriteLine("\nDados da pessoa 3:");
            Pessoa p3 = new Pessoa();
            p3.Nome = "Ryan";
            p3.Sobrenome = "Sabino";
            p3.Apelido = "Paraiba";

            Console.WriteLine("\n\nAgora eles irão se pronunciar:");
            p1.Falar();
            p2.Falar();
            p3.Falar();
            _ = Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Agora dados de conta bancária:");

            Console.Write("\nNúmero da conta: ");
            string conta = Console.ReadLine();
            Console.Write("Nome do Titular da conta: "); 
            string titular = Console.ReadLine();

            Console.Write("Saldo inical da conta: ");
            _ = float.TryParse(Console.ReadLine(), out float saldo);
            ContaBancaria conta1 = new (conta, titular, saldo);

            string acao = "";
            float valor;
            Console.WriteLine("Conta criada.\n");
            _ = Console.ReadKey();
            do
            {
                Console.Clear();
                Console.WriteLine("\n     O que deseja fazer agora:\n       E - Exibir dados\n       D - Depositar\n       S - Sacar\n       X - Fechar");
                Console.Write("       >> ");
                acao = Console.ReadLine().ToUpper();
                
                if (acao == "E")
                {
                    conta1.Exibir();
                }
                else if (acao == "D")
                {
                    Console.Write("\n     Informe o valor que será depositado: ");
                    valor = float.Parse(Console.ReadLine());
                    Console.Write(conta1.Depositar(valor));
                }
                else if (acao == "S")
                {
                    Console.Write("\n     Informe o valor que será Sacado: ");
                    valor = float.Parse(Console.ReadLine());
                    Console.Write(conta1.Sacar(valor));
                }
                else {
                    Console.WriteLine(acao != "X" ? "\n     Opção inválida!" : "\n     Obrigado por usar nossos serviços.");
                }
                _ = Console.ReadKey();

            } while (acao != "X");

            Console.Clear();
            Console.WriteLine("Agora dados de Produto");

            Console.Write("\nCódigo do produto: ");
            string produtoCod = Console.ReadLine();
            Console.Write("Descrição do produto: ");
            string produtoDesc = Console.ReadLine();
            Console.Write("Preço do produto: ");
            _ = float.TryParse(Console.ReadLine(), out float produtoPreco);
            Console.Write("Estoque atual do produto: ");
            _ = int.TryParse(Console.ReadLine(), out int produtoQtde);

            Produto prod1 = new (produtoCod, produtoDesc, produtoPreco, produtoQtde);

            acao = "";
            int qtde;
            Console.WriteLine("Produto Criado.\n");
            _ = Console.ReadKey();
            do
            {
                Console.Clear();
                Console.WriteLine("\n     O que deseja fazer agora:\n       E - Exibir dados\n       R - Repor produto\n       V - Vender produto\n       X - Fechar");
                Console.Write("       >> ");
                acao = Console.ReadLine().ToUpper();

                if (acao == "E")
                {
                    prod1.Exibir();
                }
                else if (acao == "D")
                {
                    Console.Write("\n     Informe a quantidade que será reposta: ");
                    qtde = int.Parse(Console.ReadLine());
                    Console.Write(prod1.Repor(qtde));
                }
                else if (acao == "S")
                {
                    Console.Write("\n     Informe a quantidade vendida: ");
                    qtde = int.Parse(Console.ReadLine());
                    Console.Write(prod1.Vender(qtde));
                }
                else
                {
                    Console.WriteLine(acao != "X" ? "\n     Opção inválida!" : "\n     Obrigado por usar nossos serviços.");
                }
                _ = Console.ReadKey();

            } while (acao != "X");


        }
    }
}
