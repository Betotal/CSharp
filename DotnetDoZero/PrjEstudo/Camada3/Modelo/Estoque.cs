using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Estoque
    {
        public int ID { get; set; }
        public int PRODUTOID { get; set; }
        public int QTDE { get; set; } 
        public string LOCAL { get; set; } = null!; 

        public virtual Produto Produto {get; set;} = null!;
    }
}