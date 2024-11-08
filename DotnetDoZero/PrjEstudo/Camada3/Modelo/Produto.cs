using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Modelo
{
    public partial class Produto
    {
        public Produto(){
            PrdCategoria = new HashSet<ProdutoCategoria>();
        } 

        public int ID { get; set; }
        public string? NOME { get; set; } 
        public string? COR { get; set; }

        public virtual Estoque ? Mass {get; set;}
        public virtual ICollection<ProdutoCategoria> PrdCategoria { get; set; }
    }
}