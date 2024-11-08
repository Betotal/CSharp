using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoCategoria
    {
        public int PRODUTO_ID { get; set; }
        public int CATEGORIA_ID { get; set; }   
        public virtual Produto Produto { get; set; } = null!;
        public virtual Categoria Categoria { get; set; } = null!;

    }
}