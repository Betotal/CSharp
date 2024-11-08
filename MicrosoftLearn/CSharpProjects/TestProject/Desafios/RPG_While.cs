using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace TestProject.Desafios
{
    public class RPGWhile
    {
        public static void RPG(){
            System.Console.Clear();
            Console.WriteLine("Batalha de RPG, usando ataques randomicos.");
            Console.WriteLine("Heroi e Monstro inicial com 10 pontos de vida. Que vença o melhor");
            Console.WriteLine();

            int Heroi, Monstro, valorAtaque;
            int ataque = 1;
            Random lanceDado = new ();


            string resposta;
            do
            {
                Heroi = 10;
                Monstro = 10;

                do
                {
                    valorAtaque = lanceDado.Next(1, 9); ;
                    if (ataque == 1)
                    {
                        Monstro -= valorAtaque;
                        System.Console.WriteLine($"Monstro recebe um ataque de {valorAtaque} e agora tem {Monstro} de vida!");
                        ataque = 0;
                    }
                    else if (ataque == 0)
                    {
                        Heroi -= valorAtaque;
                        System.Console.WriteLine($"Heroi recebe um ataque de {valorAtaque} e agora tem {Heroi} de vida!");
                        ataque = 1;
                    }

                } while (Heroi > 0 && Monstro > 0);

                Console.WriteLine();
                Console.WriteLine((Heroi <= 0) ? "Monstro é o venecedor" : "Heroi é o vencedor");
                Console.WriteLine();

                Console.Write("Deseja jogar de novo? (S/N): ");
                resposta = Console.ReadLine().ToLower();

                ataque = ataque == 1 ? 0 : 1;

            } while (resposta == "s");
        }
    }
}