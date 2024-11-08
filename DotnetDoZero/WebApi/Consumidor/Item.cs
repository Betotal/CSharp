using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumidor
{
    public class Item
    {
        public long Id {get; set;}
        public string? Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}