using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_OO
{
    class Produto
    {
        private string codigo;
        private string descricao;
        private float preco;
        private int estoque;

        public Produto(string codigo, string descricao, float preco, int qtde)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.estoque = qtde;
        }

        public void Exibir()
        {
            Console.WriteLine($"\nProduto: {codigo} - {descricao}");
            Console.WriteLine($"Preço: {preco:F2}");
            Console.WriteLine($"Estoque: {estoque:F2}");
        }

        public string Repor(int qtde)
        {
            estoque += qtde;

            return $"\n       Reposição concluida. Estoque atual: {estoque}";

        }

        public string Vender(int qtde)
        {
            if (estoque >= qtde)
            {
                estoque -= qtde;
                return $"\n       Venda concluida. Estoque atual: {estoque}";
            }
            else
            {
                return "\n       Venda cancelada. Estoque insuficiente.";
            }
        }

    }
}
