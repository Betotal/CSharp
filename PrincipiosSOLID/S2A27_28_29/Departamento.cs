using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class Departamento : IDisposable
    {
        private Escola _escola;
        private string Nome { get; set; }
        public List<Professor> Professores { get; set; } // Agregação

        internal Departamento(Escola escola, string nome)
        {
            this._escola = escola;
            this.Nome = nome;
        }

        public void Dispose()
        {  //Agregação, pois a classe professor pode existir sem a classe Departamento
            // destroi o departamento
        }

    }
}