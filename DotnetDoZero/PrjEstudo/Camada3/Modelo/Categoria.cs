using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Categoria
    {
        public Categoria(){
            CatProduto = new HashSet<ProdutoCategoria>();
        } 
        public int ID { get; set; }
        public string NOME { get; set; } = null!;
        public virtual ICollection<ProdutoCategoria> CatProduto {get; set;}
    }
}