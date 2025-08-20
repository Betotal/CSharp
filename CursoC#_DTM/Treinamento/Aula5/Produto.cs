using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Produto
    {
        private string nome;
        private float preco;
        private int estoque;

        public string NomeProd
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) nome = value;
            }
        }
        public float PrecoProd
        {
            get { return preco; }
            set
            {
                preco = (preco >= 0 ? value : preco);
            }
        }
        public int EstoqueProd
        {
            get { return estoque; }
            set
            {
                estoque = value >= 0 ? value : estoque;
            }
        }
        public string ExibirProduto()
        {
            return $"Nome do produto: {nome} - Preço: {preco:F2} - Estoque: {estoque}";
        }
    }
}
