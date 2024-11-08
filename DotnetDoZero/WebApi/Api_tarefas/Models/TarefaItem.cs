using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_tarefas.Models
{
    public class TarefaItem
    {
        public long Id { get; set; }
        public string?  Nome { get; set; }
        public bool Finalizado { get; set; }

    }
}