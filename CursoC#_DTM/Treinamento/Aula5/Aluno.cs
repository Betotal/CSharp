using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Aluno
    {
        private string nome;
        private int idade;
        private float notaFinal;

        public string Nome
        {
            get { return nome; }
            set
            {
                if(!string.IsNullOrWhiteSpace(value)) nome = value;
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                idade = value > 0 ? value : idade;
            }
        }
        public float NotaFinal
        {
            get { return notaFinal; }
            set
            {
                notaFinal = (value >= 0 && value <= 10)? value : notaFinal;
            }
        }

        public string ExibirResumo()
        {
            return $"Aluno: {Nome} - Idade: {Idade} - Nota Final {NotaFinal}";
        }
    }
}
