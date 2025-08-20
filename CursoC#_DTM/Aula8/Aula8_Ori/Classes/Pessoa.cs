using Aula8.Enum;

namespace Aula8.Classes
{
    public class Pessoa
    {
        //local
        private string Nome { get; set; }
        private int Idade { get; set; }
        private EnumGenero Genero { get; set; }

        //Construtor
        public Pessoa(string nome, int idade, EnumGenero genero)
        {
            Nome = !string.IsNullOrWhiteSpace(nome) ? nome : "Sem nome";
            Idade = idade > 0 ? idade : 0;
            Genero = genero;
        }

        //externo
        public int IdadeGet { get { return Idade; } }
        public EnumGenero GeneroGet { get { return Genero; } } // ou idem abaixo
        public string NomeGet { get => Nome; }  // ou idem acima

    }
}
