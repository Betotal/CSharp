using System;

namespace Aula4_OO
{
    public class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public string Apelido;

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} {Sobrenome} - {Apelido}");
        }
    }
}
