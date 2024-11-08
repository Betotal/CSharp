using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S1A11
{
    public class ClienteRico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            if(id < 0)
                throw new InvalidOperationException("Id inválido");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException();

            Id = id;
            Nome = nome;
            Endereco = endereco;        

        }

    }
}