using Aula8.Enum;

namespace Aula8.Classes
{
    public class Pessoa
    {
        private string _Nome { get; set; }
        private int _Idade { get; set; }
        private EnumGenero _Genero { get; set; }

        public Pessoa(string nome, int idade, EnumGenero genero)
        {
            _Nome = !string.IsNullOrWhiteSpace(nome) ? nome : "Sem nome";
            _Idade = idade > 0 ? idade : 0;
            _Genero = genero;
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }
        }
        public int Idade { get { return _Idade; } }
        public EnumGenero Genero { get => _Genero; } // quando o retorno for simples

    }

}

